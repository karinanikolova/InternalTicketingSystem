using ITS.Core.Models.Comment;
using ITS.Core.Models.Ticket;
using ITS.Core.Services;
using ITS.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ITS.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentsController : BaseApiController
	{
		private readonly ICommentService _commentService;
		private readonly ITicketService _ticketService;

		public CommentsController(ICommentService commentService, ITicketService ticketService)
		{
			_commentService = commentService;
			_ticketService = ticketService;
		}

		[HttpPost("/api/tickets/{ticketId:guid}/comments")]
		public async Task<IActionResult> CreateComment(Guid ticketId, [FromBody] CommentCreateDto commentDto)
		{
			var ticket = await _ticketService.GetTicketByIdAsync(ticketId);

			if (ticket == null)
			{
				return NotFound($"Ticket with ID {ticketId} does not exist.");
			}

			var userId = User.UserId();

			if (userId != ticket.CreatorId && userId != ticket.AssignedToUserId && User.IsAdmin() == false)
			{
				return Unauthorized("You do not have permission to comment on this ticket.");
			}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			await _commentService.CreateCommentAsync(ticketId, commentDto, userId!.Value);

			return Ok("Comment created successfully.");
		}

		[HttpDelete("/api/tickets/{ticketId:guid}/comments/{commentId:guid}")]
		public async Task<IActionResult> DeleteComment(Guid ticketId, Guid commentId)
		{
			return Ok("Functionality not implemented.");
		}
	}
}