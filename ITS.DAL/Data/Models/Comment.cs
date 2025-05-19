using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ITS.DAL.Constants.DataConstants.Comment;

namespace ITS.DAL.Data.Models
{
	public class Comment
	{
		[Required]
		[Comment("Comment identifier")]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(MessageMaxLength)]
		[Comment("Comment description")]
		public string Message { get; set; }

		[Required]
		[Comment("Comment creation date")]
		public DateTime CreatedOn { get; set; }

		[Required]
		[Comment("Ticket identifier")]
		public Guid TicketId { get; set; }

		[ForeignKey(nameof(TicketId))]
		public Ticket Ticket { get; set; }

		[Required]
		[Comment("Comment creator identifier")]
		public Guid CreatorId { get; set; }

		[ForeignKey(nameof(CreatorId))]
		public ApplicationUser Creator { get; set; }
	}
}