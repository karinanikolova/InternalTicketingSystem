using ITS.Core.Models.Comment;
using ITS.Core.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static ITS.DAL.Constants.DataConstants.Comment;

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

		[HttpPut("/api/tickets/{ticketId:guid}/comments/{commentId:guid}")]
		public async Task<IActionResult> UpdateComment(Guid ticketId, Guid commentId, [FromBody] CommentUpdateDto commentDto)
		{
			if (await _ticketService.DoesTicketExistAsync(ticketId) == false)
			{
				return NotFound($"Ticket with ID {ticketId} does not exist.");
			}

			var comment = await _commentService.GetCommentByIdAsync(commentId);

			if (comment == null)
			{
				return NotFound($"Comment with ID {commentId} does not exist.");
			}

			if (comment.TicketId != ticketId)
			{
				return BadRequest("Comment does not belong to the specified ticket.");
			}

			var userId = User.UserId();

			if (userId != comment.CreatorId && User.IsAdmin() == false)
			{
				return Unauthorized("You do not have permission to update this comment.");
			}

			if (string.IsNullOrWhiteSpace(commentDto.Message))
			{
				ModelState.AddModelError(nameof(commentDto.Message), "Comment message cannot be empty.");
			}

			if (commentDto.Message.Length > MessageMaxLength)
			{
				ModelState.AddModelError(nameof(commentDto.Message), $"Comment message cannot exceed {MessageMaxLength} characters.");
			}

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			await _commentService.UpdateCommentAsync(commentId, commentDto);

			return Ok("Comment updated successfully.");
		}

		[HttpDelete("/api/tickets/{ticketId:guid}/comments/{commentId:guid}")]
		public async Task<IActionResult> DeleteComment(Guid ticketId, Guid commentId)
		{
			var ticket = await _ticketService.GetTicketByIdAsync(ticketId);

			if (ticket == null)
			{
				return NotFound($"Ticket with ID {ticketId} does not exist.");
			}

			var comment = await _commentService.GetCommentByIdAsync(commentId);

			if (comment == null)
			{
				return NotFound($"Comment with ID {commentId} does not exist.");
			}

			if (comment.TicketId != ticketId)
			{
				return BadRequest("Comment does not belong to the specified ticket.");
			}

			var userId = User.UserId();

			if (userId != comment.CreatorId && User.IsAdmin() == false)
			{
				return Unauthorized("You do not have permission to delete this comment.");
			}

			await _commentService.DeleteCommentAsync(commentId);

			return Ok("Comment deleted successfully.");
		}
	}
}