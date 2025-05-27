using ITS.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITS.DAL.Data.Configuration
{
	internal class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder.Property(u => u.UserName)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(u => u.Email)
				.IsRequired();

			builder.Property(u => u.PasswordHash)
				.IsRequired();

			builder.ToTable("Users");

			builder.HasData(DataSeed.Users);
		}
	}
}