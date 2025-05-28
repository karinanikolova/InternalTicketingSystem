using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.DataConstants.ApplicationUser;
using static ITS.DAL.Constants.MessageConstants;

namespace ITS.Core.Models.Authentication
{
	public class LoginDto
	{
		[Required]
		[StringLength(UserEmailMaxLength, MinimumLength = UserNameMinLength, ErrorMessage = FieldLengthMessage)]
		[Display(Name = "Email or username")]
		public string UserNameOrEmail { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Display(Name = "Remember me")]
		public bool RememberMe { get; set; }
	}
}