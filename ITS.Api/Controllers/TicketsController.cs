using ITS.Core.Models.Ticket;
using ITS.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ITS.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TicketsController : BaseApiController
	{
		private readonly ITicketService _ticketService;
		private readonly IAuthenticationService _authService;

		public TicketsController(ITicketService ticketService, IAuthenticationService authService)
		{
			_ticketService = ticketService;
			_authService = authService;
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

		[HttpGet("{ticketId:guid}")]
		public async Task<IActionResult> GetTicketById(Guid ticketId)
		{
			var ticket = await _ticketService.GetTicketByIdAsync(ticketId);

			if (ticket == null)
			{
				return NotFound($"Ticket with ID {ticketId} was not found.");
			}

			return Ok(ticket);
		}
		
		[HttpPost]
		public async Task<IActionResult> CreateTicket([FromBody] TicketCreateDto ticketDto)
		{
			if (!await _ticketService.DoesCategoryExist(ticketDto.CategoryId))
			{
				ModelState.AddModelError(nameof(ticketDto.CategoryId), "Ticket category does not exist.");
			}

			if (!_ticketService.DoesStatusExist(ticketDto.StatusId))
			{
				ModelState.AddModelError(nameof(ticketDto.StatusId), "Ticket status does not exist.");
			}

			if (!_ticketService.DoesPriorityExist(ticketDto.PriorityId))
			{
				ModelState.AddModelError(nameof(ticketDto.PriorityId), "Ticket priority does not exist.");
			}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var userId = User.UserId();
			var adminUserId = await _authService.GetAdminIdAsync();

			if (userId == null) // Is this validation necessary?
			{
				return Unauthorized("User is not authenticated or does not have the required permissions.");
			}

			await _ticketService.CreateTicketAsync(ticketDto, userId.Value, adminUserId);

			return Ok("Ticket created successfully.");
		}

		[HttpPut("{ticketId:guid}")]
		public async Task<IActionResult> UpdateTicket(Guid ticketId, [FromBody] TicketUpdateDto ticketDto)
		{
			if (await _ticketService.DoesTicketExistAsync(ticketId) == false)
			{
				return NotFound($"Ticket with ID {ticketId} does not exist.");
			}

			if (User.UserId() != ticketDto.CreatorId && User.IsAdmin() == false)
			{
				return Unauthorized("You do not have permission to update this ticket.");
			}

			if (!_ticketService.DoesStatusExist(ticketDto.StatusId))
			{
				ModelState.AddModelError(nameof(ticketDto.StatusId), "Ticket status does not exist.");
			}

			if (!_ticketService.DoesPriorityExist(ticketDto.PriorityId))
			{
				ModelState.AddModelError(nameof(ticketDto.PriorityId), "Ticket priority does not exist.");
			}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			await _ticketService.UpdateTicketAsync(ticketId, ticketDto);

			return Ok("Ticket updated successfully.");
		}

		[HttpDelete("{ticketId:guid}")]
		public async Task<IActionResult> DeleteTicket(Guid ticketId)
		{
			var ticketToDelete = await _ticketService.GetTicketByIdAsync(ticketId);

			if (ticketToDelete == null)
			{
				return NotFound($"Ticket with ID {ticketId} does not exist.");
			}

			if (User.UserId() != ticketToDelete.CreatorId && User.IsAdmin() == false)
			{
				return Unauthorized("You do not have permission to delete this ticket.");
			}

			if (ticketToDelete.Comments.Count > 0)
			{
				await _ticketService.DeleteCommentsByTicketIdAsync(ticketId);
			}

			await _ticketService.DeleteTicketAsync(ticketId);

			return Ok("Ticket deleted successfully.");
		}
	}
}