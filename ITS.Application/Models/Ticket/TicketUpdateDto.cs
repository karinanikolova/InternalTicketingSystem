using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.MessageConstants;

namespace ITS.Core.Models.Ticket
{
	public class TicketUpdateDto : TicketCreateDto
	{
		public Guid CreatorId { get; set; }

		[Required(ErrorMessage = RequiredFieldMessage)]
		[Display(Name = "Assigned to user")]
		public Guid AssignedToUserId { get; set; }
	}
}