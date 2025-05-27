using ITS.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITS.DAL.Data.Configuration
{
	internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> builder)
		{
			builder
				.HasMany(d => d.Employees)
				.WithOne(u => u.Department)
				.HasForeignKey(u => u.DepartmentId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(DataSeed.Departments);
		}
	}
}