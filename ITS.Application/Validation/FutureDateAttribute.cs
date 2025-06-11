using System.ComponentModel.DataAnnotations;

namespace ITS.Core.Validation
{
	public class FutureDateAttribute : ValidationAttribute
	{
		public FutureDateAttribute()
			: base("The date must be today or in the future.")
		{

		}

		public FutureDateAttribute(string errorMessage)
			: base(errorMessage)
		{

		}

		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return ValidationResult.Success;
			}

			if (value is DateTime dateValue)
			{
				if (dateValue.Date >= DateTime.Today)
				{
					return ValidationResult.Success;
				}
			}

			return new ValidationResult(ErrorMessage = "The specified date is not valid.");
		}
	}
}