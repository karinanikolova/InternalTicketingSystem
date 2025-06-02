using ITS.Core.Models.Comment;
using ITS.Core.Models.Ticket;
using ITS.DAL.Data.Models;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Utilities.Contracts;
using Microsoft.EntityFrameworkCore;
using static ITS.DAL.Constants.CustomRoles;

namespace ITS.Core.Services
{
	public class TicketService : ITicketService
	{
		private readonly IRepository _repository;

		public TicketService(IRepository repository)
		{
			_repository = repository;
		}

		public async Task<IEnumerable<TicketViewDto>> GetAllTicketsAsync(string userRole, bool isSupportAgent, string userId)
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
					.Select(c => new CommentDto()
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
					.Where(t => t.AssignedToUserId == Guid.Parse(userId))
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
						.Select(c => new CommentDto()
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
					.Where(t => t.CreatorId == Guid.Parse(userId))
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
						.Select(c => new CommentDto()
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
						.Select(c => new CommentDto()
						{
							Id = c.Id,
							Message = c.Message,
							CreatedOn = c.CreatedOn,
							TicketId = c.TicketId,
							CreatorId = c.CreatorId
						}).ToList()
					})
					.FirstOrDefaultAsync();

		public async Task CreateTicketAsync(TicketCreateDto ticketFormDto)
		{
			throw new NotImplementedException();
		}
	}
}