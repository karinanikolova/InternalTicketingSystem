using ITS.Core.Models.Comment;

namespace ITS.Core.Services.Contracts
{
	public interface ICommentService
	{
		Task CreateCommentAsync(Guid ticketId, CommentCreateDto commentDto, Guid userId);
	}
}