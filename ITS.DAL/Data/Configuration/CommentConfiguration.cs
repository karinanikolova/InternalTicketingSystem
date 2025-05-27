using ITS.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITS.DAL.Data.Configuration
{
	internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
			builder
				.HasOne(c => c.Creator)
				.WithMany()
				.HasForeignKey(c => c.CreatorId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.HasOne(c => c.Ticket)
				.WithMany(t => t.Comments)
				.HasForeignKey(c => c.TicketId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.HasData(DataSeed.Comments);
		}
	}
}