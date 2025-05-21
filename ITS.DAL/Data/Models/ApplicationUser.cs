using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ITS.DAL.Constants.DataConstants.ApplicationUser;
using static ITS.DAL.Constants.DataConstants.Department;

namespace ITS.DAL.Data.Models
{
	public class ApplicationUser : IdentityUser<Guid>
	{
		[Required]
		[MaxLength(UserFirstNameMaxLength)]
		[PersonalData]
		public string FirstName { get; set; }

		[Required]
		[MaxLength(UserLastNameMaxLength)]
		[PersonalData]
		public string LastName { get; set; }

		[Required]
		[MaxLength(DepartmentNameMaxLength)]
		[PersonalData]
		public Guid DepartmentId { get; set; }

		[ForeignKey(nameof(DepartmentId))]
		public Department Department {  get; set; }
	}
}