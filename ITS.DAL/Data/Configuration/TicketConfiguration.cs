using ITS.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITS.DAL.Data.Configuration
{
	internal class TicketConfiguration : IEntityTypeConfiguration<Ticket>
	{
		public void Configure(EntityTypeBuilder<Ticket> builder)
		{
			builder
				.HasOne(t => t.Creator)
				.WithMany()
				.HasForeignKey(t => t.CreatorId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.HasOne(t => t.AssignedToUser)
				.WithMany()
				.HasForeignKey(t => t.AssignedToUserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.HasOne(t => t.Category)
				.WithMany(c => c.Tickets)
				.HasForeignKey(t => t.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(DataSeed.Tickets);
		}
	}
}