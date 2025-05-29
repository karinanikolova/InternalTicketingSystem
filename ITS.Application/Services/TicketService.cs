using ITS.Core.Models.Comment;
using ITS.Core.Models.Ticket;
using ITS.DAL.Data.Models;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Utilities.Contracts;
using Microsoft.EntityFrameworkCore;

namespace ITS.Core.Services
{
	public class TicketService : ITicketService
	{
		private readonly IRepository _repository;

		public TicketService(IRepository repository)
		{
			_repository = repository;
		}

		public async Task<IEnumerable<TicketDto>> GetAllTicketsAsync()
			=> await _repository.AllReadOnly<Ticket>()
				.Include(t => t.Comments)
				.Select(t => new TicketDto()
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

		public async Task<TicketDto?> GetTicketByIdAsync(Guid ticketId)
			=> await _repository.AllReadOnly<Comment>()
				.Include(c => c.Ticket)
				.Where(c => c.TicketId == ticketId)
				.Select(c => new TicketDto()
				{
					Id = c.Ticket.Id,
					Title = c.Ticket.Title,
					Description = c.Ticket.Description,
					CategoryId = c.Ticket.CategoryId,
					Status = c.Ticket.Status,
					Priority = c.Ticket.Priority,
					CreatedOn = c.Ticket.CreatedOn,
					DueDate = c.Ticket.DueDate,
					CreatorId = c.Ticket.CreatorId,
					AssignedToUserId = c.Ticket.AssignedToUserId,
					Comments = c.Ticket.Comments
						.Select(c => new CommentDto()
						{
							Id = c.Id,
							Message = c.Message,
							CreatedOn = c.CreatedOn,
							TicketId = c.TicketId,
							CreatorId = c.CreatorId
						}).ToList(),
				})
				.FirstOrDefaultAsync();
	}
}