using ITS.Core.Models.Comment;
using ITS.DAL.Enums;

namespace ITS.Core.Models.Ticket
{
	public class TicketDto
	{
		public Guid Id { get; set; }
		public string Title { get; set; }

		public string Description { get; set; }

		public Guid CategoryId { get; set; }

		public Status Status { get; set; }

		public Priority Priority { get; set; }

		public DateTime CreatedOn { get; set; }

		public DateTime? DueDate { get; set; }

		public Guid CreatorId { get; set; }

		public Guid AssignedToUserId { get; set; }

		public ICollection<CommentDto> Comments { get; set; } = new List<CommentDto>();
	}
}