using ITS.Core.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
			var userRole = User.FindUserRole();
			var isSupportAgent = User.IsSupportAgent();
			var userId = User.UserId();

			var tickets = await _ticketService.GetAllTicketsAsync(userRole, isSupportAgent, userId);

			if (tickets == null || !tickets.Any())
			{
				return NotFound("No tickets found.");
			}

			return Ok(tickets);
		}

		[HttpGet("{ticketId}")]
		public async Task<IActionResult> GetTicketById(string ticketId)
		{
			if (!Guid.TryParse(ticketId, out var parsedTicketId))
			{
				return BadRequest("Invalid ticket ID format.");
			}

			var ticket = await _ticketService.GetTicketByIdAsync(parsedTicketId);

			if (ticket == null)
			{
				return NotFound($"Ticket with ID {ticketId} was not found.");
			}

			return Ok(ticket);
		}

		[HttpPost]
		public async Task<IActionResult> CreateTicket()
		{
			return BadRequest("Create ticket functionality is not implemented yet.");
		}
	}
}