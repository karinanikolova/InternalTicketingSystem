using ITS.Core.Models.Comment;

namespace ITS.Core.Services.Contracts
{
	public interface ICommentService
	{
		Task CreateCommentAsync(Guid ticketId, CommentCreateDto commentDto, Guid userId);

		Task<CommentViewDto?> GetCommentByIdAsync(Guid commentId);

		Task UpdateCommentAsync(Guid commentId, CommentUpdateDto commentDto);

		Task DeleteCommentAsync(Guid commentId);
	}
}