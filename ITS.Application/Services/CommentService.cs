using ITS.Core.Models.Comment;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Models;
using ITS.DAL.Data.Utilities.Contracts;

namespace ITS.Core.Services
{
	public class CommentService : ICommentService
	{
		private readonly IRepository _repository;

		public CommentService(IRepository repository)
		{
			_repository = repository;
		}

		public async Task CreateCommentAsync(Guid ticketId, CommentCreateDto commentDto, Guid userId)
		{
			var comment = new Comment()
			{
				Message = commentDto.Message,
				CreatedOn = DateTime.UtcNow,
				TicketId = ticketId,
				CreatorId = userId
			};

			await _repository.AddAsync<Comment>(comment);
			await _repository.SaveChangesAsync();
		}
	}
}