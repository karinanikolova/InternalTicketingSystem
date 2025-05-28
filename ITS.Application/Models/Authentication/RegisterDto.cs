using ITS.DAL.Data.Models;
using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.DataConstants.ApplicationUser;
using static ITS.DAL.Constants.MessageConstants;

namespace ITS.Core.Models.Authentication
{
	public class RegisterDto
	{
		[Required]
		[StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength, ErrorMessage = FieldLengthMessage)]
		[Display(Name = "Username")]
		public string UserName { get; set; }

		[Required]
		[StringLength(UserFirstNameMaxLength, MinimumLength = UserFirstNameMinLength, ErrorMessage = FieldLengthMessage)]
		[Display(Name = "First name")]
		public string FirstName { get; set; }

		[Required]
		[StringLength(UserLastNameMaxLength, MinimumLength = UserLastNameMinLength, ErrorMessage = FieldLengthMessage)]
		[Display(Name = "Last name")]
		public string LastName { get; set; }

		[Required]
		[EmailAddress(ErrorMessage = InvalidEmailMessage)]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[StringLength(UserPasswordMaxLength, MinimumLength = UserPasswordMinLength, ErrorMessage = FieldLengthMessage)]
		[DataType(DataType.Password)]
		public string Password { get; set; }


		[Required]
		[StringLength(UserPasswordMaxLength, MinimumLength = UserPasswordMinLength, ErrorMessage = FieldLengthMessage)]
		[DataType(DataType.Password)]
		[Compare(nameof(Password), ErrorMessage = FailedPasswordComparisonMessage)]
		[Display(Name = "Confirm password")]
		public string ConfirmPassword { get; set; }

		[Required]
		[Display(Name = "Department")]
		public string DepartmentName { get; set; }

		public IEnumerable<Department> Departments { get; set; } = new List<Department>();
	}
}