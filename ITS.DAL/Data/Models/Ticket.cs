using ITS.DAL.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ITS.DAL.Constants.DataConstants.Ticket;

namespace ITS.DAL.Data.Models
{
	public class Ticket
	{
		[Required]
		[Comment("Ticket identifier")]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(TitleMaxLength)]
		[Comment("Ticket title")]
		public string Title { get; set; }

		[Required]
		[MaxLength(DescriptionMaxLength)]
		[Comment("Ticket description")]
		public string Description { get; set; }

		[Required]
		[Comment("Ticket category identifier")]
		public Guid CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public Category Category { get; set; }

		[Required]
		[Comment("Ticket status")]
		public Status Status { get; set; }

		[Required]
		[Comment("Ticket priority")]
		public Priority Priority { get; set; }

		[Required]
		[Comment("Ticket creation date")]
		public DateTime CreatedOn { get; set; }

		[Comment("Ticket due date")]
		public DateTime? DueDate { get; set; }

		[Required]
		[Comment("Ticket creator identifier")]
		public Guid CreatorId { get; set; }

		[ForeignKey(nameof(CreatorId))]
		public ApplicationUser Creator { get; set; }

		[Required]
		[Comment("Ticket assigned to user identifier")]
		public Guid AssignedToUserId { get; set; }

		[ForeignKey(nameof(AssignedToUserId))]
		public ApplicationUser AssignedToUser { get; set; }

		public ICollection<Comment> Comments { get; set; } = new List<Comment>();
	}
}