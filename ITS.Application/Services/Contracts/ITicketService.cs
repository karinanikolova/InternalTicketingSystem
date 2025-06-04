using ITS.Core.Models.Ticket;

namespace ITS.Core.Services.Contracts
{
	public interface ITicketService
	{
		Task<IEnumerable<TicketViewDto>> GetAllTicketsAsync(string userRole, bool isSupportAgent, Guid? userId);

		Task<TicketViewDto?> GetTicketByIdAsync(Guid ticketId);

		Task CreateTicketAsync(TicketCreateDto ticketFormDto, Guid creatorId, Guid adminUserId);

		bool DoesStatusExist(int statusId);

		bool DoesPriorityExist(int priorityId);
	}
}