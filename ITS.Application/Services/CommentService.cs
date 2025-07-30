using ITS.Core.Models.Comment;
using ITS.Core.Services.Contracts;
using ITS.DAL.Data.Models;
using ITS.DAL.Data.Utilities.Contracts;
using Microsoft.EntityFrameworkCore;

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

		public async Task DeleteCommentAsync(Guid commentId)
		{
			var commentToDelete = await _repository.GetByIdAsync<Comment>(commentId);

			if (commentToDelete != null)
			{
				_repository.Delete<Comment>(commentToDelete);
				await _repository.SaveChangesAsync();
			}
		}

		public async Task<CommentViewDto?> GetCommentByIdAsync(Guid commentId)
			=> await _repository.AllReadOnly<Comment>()
					.Where(c => c.Id == commentId)
					.Select(c => new CommentViewDto()
					{
						Id = c.Id,
						Message = c.Message,
						CreatedOn = c.CreatedOn,
						TicketId = c.TicketId,
						CreatorId = c.CreatorId
					})
					.FirstOrDefaultAsync();

		public async Task UpdateCommentAsync(Guid commentId, CommentUpdateDto commentUpdateDto)
		{
			var comment = await _repository.GetByIdAsync<Comment>(commentId);

			if (comment != null)
			{
				comment.Message = commentUpdateDto.Message;
			}

			await _repository.SaveChangesAsync();
		}
	}
}