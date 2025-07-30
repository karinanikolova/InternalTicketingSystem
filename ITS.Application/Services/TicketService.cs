using ITS.Core.Models.Comment;
using ITS.Core.Models.Ticket;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Models;
using ITS.DAL.Data.Utilities.Contracts;
using ITS.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using static ITS.DAL.Constants.AdminConstants;

namespace ITS.Core.Services
{
	public class TicketService : ITicketService
	{
		private readonly IRepository _repository;

		public TicketService(IRepository repository)
		{
			_repository = repository;
		}

		public async Task<IEnumerable<TicketViewDto>> GetAllTicketsAsync(string userRole, bool isSupportAgent, Guid? userId)
		{
			if (userRole == AdminRole)
			{
				return await _repository.AllReadOnly<Ticket>()
				.Include(t => t.Comments)
				.Select(t => new TicketViewDto()
				{
					Id = t.Id,
					Title = t.Title,
					Description = t.Description,
					CategoryId = t.CategoryId,
					Status = t.Status,
					Priority = t.Priority,
					CreatedOn = t.CreatedOn,
					DueDate = t.DueDate,
					CreatorId = t.CreatorId,
					AssignedToUserId = t.AssignedToUserId,
					Comments = t.Comments.Where(c => c.TicketId == t.Id)
					.Select(c => new CommentViewDto()
					{
						Id = c.Id,
						Message = c.Message,
						CreatedOn = c.CreatedOn,
						TicketId = c.TicketId,
						CreatorId = c.CreatorId
					}).ToList()
				})
				.ToListAsync();
			}

			if (isSupportAgent)
			{
				return await _repository.AllReadOnly<Ticket>()
					.Where(t => t.AssignedToUserId == userId)
					.Include(t => t.Comments)
					.Select(t => new TicketViewDto()
					{
						Id = t.Id,
						Title = t.Title,
						Description = t.Description,
						CategoryId = t.CategoryId,
						Status = t.Status,
						Priority = t.Priority,
						CreatedOn = t.CreatedOn,
						DueDate = t.DueDate,
						CreatorId = t.CreatorId,
						AssignedToUserId = t.AssignedToUserId,
						Comments = t.Comments.Where(c => c.TicketId == t.Id)
						.Select(c => new CommentViewDto()
						{
							Id = c.Id,
							Message = c.Message,
							CreatedOn = c.CreatedOn,
							TicketId = c.TicketId,
							CreatorId = c.CreatorId
						}).ToList()
					})
					.ToListAsync();
			}

			return await _repository.AllReadOnly<Ticket>()
					.Where(t => t.CreatorId == userId)
					.Include(t => t.Comments)
					.Select(t => new TicketViewDto()
					{
						Id = t.Id,
						Title = t.Title,
						Description = t.Description,
						CategoryId = t.CategoryId,
						Status = t.Status,
						Priority = t.Priority,
						CreatedOn = t.CreatedOn,
						DueDate = t.DueDate,
						CreatorId = t.CreatorId,
						AssignedToUserId = t.AssignedToUserId,
						Comments = t.Comments.Where(c => c.TicketId == t.Id)
						.Select(c => new CommentViewDto()
						{
							Id = c.Id,
							Message = c.Message,
							CreatedOn = c.CreatedOn,
							TicketId = c.TicketId,
							CreatorId = c.CreatorId
						}).ToList()
					})
					.ToListAsync();
		}

		public async Task<TicketViewDto?> GetTicketByIdAsync(Guid ticketId)
			=> await _repository.AllReadOnly<Ticket>()
					.Where(t => t.Id == ticketId)
					.Include(t => t.Comments)
					.Select(t => new TicketViewDto()
					{
						Id = t.Id,
						Title = t.Title,
						Description = t.Description,
						CategoryId = t.CategoryId,
						Status = t.Status,
						Priority = t.Priority,
						CreatedOn = t.CreatedOn,
						DueDate = t.DueDate,
						CreatorId = t.CreatorId,
						AssignedToUserId = t.AssignedToUserId,
						Comments = t.Comments.Where(c => c.TicketId == t.Id)
						.Select(c => new CommentViewDto()
						{
							Id = c.Id,
							Message = c.Message,
							CreatedOn = c.CreatedOn,
							TicketId = c.TicketId,
							CreatorId = c.CreatorId
						}).ToList()
					})
					.FirstOrDefaultAsync();

		public async Task CreateTicketAsync(TicketCreateDto ticketFormDto, Guid creatorId, Guid adminUserId)
		{
			var ticket = new Ticket()
			{
				Title = ticketFormDto.Title,
				Description = ticketFormDto.Description,
				CategoryId = ticketFormDto.CategoryId,
				Status = (Status)ticketFormDto.StatusId,
				Priority = (Priority)ticketFormDto.PriorityId,
				CreatedOn = DateTime.UtcNow,
				DueDate = ticketFormDto.DueDate, // Should probably rewrite according to the format used in the form
				CreatorId = creatorId,
				AssignedToUserId = adminUserId
			};

			await _repository.AddAsync<Ticket>(ticket);
			await _repository.SaveChangesAsync();
		}

		public async Task UpdateTicketAsync(Guid ticketId, TicketUpdateDto ticketUpdateDto)
		{
			var ticket = await _repository.GetByIdAsync<Ticket>(ticketId);

			if (ticket != null)
			{
				ticket.Title = ticketUpdateDto.Title;
				ticket.Description = ticketUpdateDto.Description;
				ticket.CategoryId = ticketUpdateDto.CategoryId;
				ticket.Status = (Status)ticketUpdateDto.StatusId;
				ticket.Priority = (Priority)ticketUpdateDto.PriorityId;
				ticket.DueDate = ticketUpdateDto.DueDate;
				ticket.AssignedToUserId = ticketUpdateDto.AssignedToUserId;
			}

			await _repository.SaveChangesAsync();
		}

		public async Task DeleteTicketAsync(Guid ticketId)
		{
			var ticketToDelete = await _repository.GetByIdAsync<Ticket>(ticketId);

			if (ticketToDelete != null)
			{
				_repository.Delete<Ticket>(ticketToDelete);
				await _repository.SaveChangesAsync();
			}
		}

		public async Task DeleteCommentsByTicketIdAsync(Guid ticketId)
		{
			var commentsToDelete = await _repository.All<Comment>()
				.Where(c => c.TicketId == ticketId)
				.ToArrayAsync();

			_repository.DeleteRange<Comment>(commentsToDelete);
			await _repository.SaveChangesAsync();
		}

		public async Task<bool> DoesTicketExistAsync(Guid ticketId)
			=> await _repository.AllReadOnly<Ticket>()
				.AnyAsync(t => t.Id == ticketId);

		public bool DoesStatusExist(int statusId)
			=> Enum.IsDefined(typeof(Status), statusId);

		public bool DoesPriorityExist(int priorityId)
			=> Enum.IsDefined(typeof(Priority), priorityId);

		public async Task<bool> DoesCategoryExist(Guid categoryId)
			=> await _repository.AllReadOnly<Category>()
				.AnyAsync(c => c.Id == categoryId);
	}
}