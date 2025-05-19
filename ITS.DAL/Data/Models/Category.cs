using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static ITS.DAL.Constants.DataConstants.Category;

namespace ITS.DAL.Data.Models
{
	public class Category
	{
		[Required]
		[Comment("Category identifier")]
		public Guid Id { get; set; }

		[Required]
		[MaxLength(NameMaxLength)]
		[Comment("Category name")]
		public string Name { get; set; }

		public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
	}
}