using ITS.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ITS.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TicketsController : BaseApiController
	{
		private readonly ITicketService _ticketService;

		public TicketsController(ITicketService ticketService)
		{
			_ticketService = ticketService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllTickets()
		{
			var tickets = await _ticketService.GetAllTicketsAsync();

			if (tickets == null || !tickets.Any())
			{
				return NotFound("No tickets found.");
			}

			return Ok(tickets);
		}

		[HttpGet("{ticketId}")]
		public async Task<IActionResult> GetTicketById(Guid ticketId)
		{
			var ticket = await _ticketService.GetTicketByIdAsync(ticketId);

			if (ticket == null)
			{
				return NotFound($"Ticket with ID {ticketId} was not found.");
			}

			return Ok(ticket);
		}
	}
}