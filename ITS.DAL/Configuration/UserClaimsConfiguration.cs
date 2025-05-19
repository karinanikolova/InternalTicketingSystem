using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITS.DAL.Configuration
{
	internal class UserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<Guid>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserClaim<Guid>> builder)
		{
			builder.ToTable("UserClaims");
		}
	}
}