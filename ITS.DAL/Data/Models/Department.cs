using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.DataConstants.Department;

namespace ITS.DAL.Data.Models
{
	public class Department
	{
		[Required]
		[Comment("Department identifier")]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(DepartmentNameMaxLength)]
		[Comment("Department name")]
		public string Name { get; set; }

		public ICollection<ApplicationUser> Employees { get; set; } = new List<ApplicationUser>();
	}
}