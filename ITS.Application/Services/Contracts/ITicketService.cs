using ITS.Core.Models.Ticket;

namespace ITS.Core.Services.Contracts
{
	public interface ITicketService
	{
		Task<IEnumerable<TicketDto>> GetAllTicketsAsync();

		Task<TicketDto?> GetTicketByIdAsync(Guid ticketId);
	}
}