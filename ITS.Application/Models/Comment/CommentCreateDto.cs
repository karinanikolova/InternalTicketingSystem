using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.DataConstants.Comment;
using static ITS.DAL.Constants.MessageConstants;

namespace ITS.Core.Models.Comment
{
	public class CommentCreateDto
	{
		[Required(ErrorMessage = RequiredFieldMessage)]
		[StringLength(MessageMaxLength, MinimumLength = MessageMinLength, ErrorMessage = FieldLengthMessage)]
		public string Message { get; set; }
	}
}