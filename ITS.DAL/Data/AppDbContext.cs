using ITS.DAL.Configuration;
using ITS.DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ITS.DAL.Data
{
	public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{

		}

		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.ApplyConfiguration(new UserConfiguration());
			builder.ApplyConfiguration(new UserClaimsConfiguration());
			builder.ApplyConfiguration(new TicketConfiguration());
			builder.ApplyConfiguration(new CommentConfiguration());
			builder.ApplyConfiguration(new CategoryConfiguration());

			// Specifying Identity entities table names
			builder.Entity<ApplicationRole>().ToTable("Roles");
			builder.Entity<IdentityUserRole<Guid>>().ToTable("UserRoles");
			builder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogins");
			builder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaims");
			builder.Entity<IdentityUserToken<Guid>>().ToTable("UserTokens");
		}
	}
}