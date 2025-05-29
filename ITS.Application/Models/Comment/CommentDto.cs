namespace ITS.Core.Models.Comment
{
	public class CommentDto
	{
		public Guid Id { get; set; }
		public string Message { get; set; }

		public DateTime CreatedOn { get; set; }

		public Guid TicketId { get; set; }

		public Guid CreatorId { get; set; }
	}
}