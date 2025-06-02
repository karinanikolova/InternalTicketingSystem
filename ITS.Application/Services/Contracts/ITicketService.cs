using ITS.Core.Models.Ticket;

namespace ITS.Core.Services.Contracts
{
	public interface ITicketService
	{
		Task<IEnumerable<TicketViewDto>> GetAllTicketsAsync(string userRole, bool isSupportAgent, string userId);

		Task<TicketViewDto?> GetTicketByIdAsync(Guid ticketId);

		Task CreateTicketAsync(TicketCreateDto ticketFormDto);
	}
}