using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.DataConstants.Ticket;
using static ITS.DAL.Constants.MessageConstants;

namespace ITS.Core.Models.Ticket
{
	public class TicketCreateDto
	{
		[Required(ErrorMessage = RequiredFieldMessage)]
		[StringLength(TitleMaxLength, MinimumLength = TitleMinLength, ErrorMessage = FieldLengthMessage)]
		public string Title { get; set; }

		[Required(ErrorMessage = RequiredFieldMessage)]
		[StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength, ErrorMessage = FieldLengthMessage)]
		public string Description { get; set; }

		[Required(ErrorMessage = RequiredFieldMessage)]
		[Display(Name = "Ticket category")]
		public Guid CategoryId { get; set; }

		public IEnumerable<Guid> Categories { get; set; } = new List<Guid>();

		[Required(ErrorMessage = RequiredFieldMessage)]
		[Display(Name = "Ticket status")]
		public int StatusId { get; set; }

		public IEnumerable<int> Statuses { get; set; } = new List<int>();

		[Required(ErrorMessage = RequiredFieldMessage)]
		[Display(Name = "Ticket priority")]
		public int PriorityId { get; set; }

		public IEnumerable<int> Priorities { get; set; } = new List<int>();

		[Display(Name = "Ticket due date")]
		[DataType(DataType.Date)]
		public DateTime? DueDate { get; set; }
	}
}