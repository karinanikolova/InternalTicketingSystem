using ITS.Core.Validation;
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
		[Range(TicketStatusMinValue, TicketStatusMaxValue, ErrorMessage = InvalidStatusMessage)]
		[Display(Name = "Ticket status")]
		public int StatusId { get; set; }

		public IEnumerable<int> Statuses { get; set; } = new List<int>();

		[Required(ErrorMessage = RequiredFieldMessage)]
		[Range(TicketPriorityMinValue, TicketPriorityMaxValue, ErrorMessage = InvalidPriorityMessage)]
		[Display(Name = "Ticket priority")]
		public int PriorityId { get; set; }

		public IEnumerable<int> Priorities { get; set; } = new List<int>();

		[DataType(DataType.Date)]
		[FutureDate]
		[Display(Name = "Ticket due date")]
		public DateTime? DueDate { get; set; }
	}
}