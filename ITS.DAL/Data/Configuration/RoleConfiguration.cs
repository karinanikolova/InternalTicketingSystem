using ITS.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITS.DAL.Data.Configuration
{
	internal class RoleConfiguration : IEntityTypeConfiguration<ApplicationRole>
	{
		public void Configure(EntityTypeBuilder<ApplicationRole> builder)
		{
			builder.ToTable("Roles");

			builder.HasData(DataSeed.Roles);
		}
	}
}