using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GameScoreAPI.Domain.Entities;

namespace GameScoreAPI.Persistence.Configurations
{
	public class MatchConfiguration : IEntityTypeConfiguration<Match>
	{
		public void Configure(EntityTypeBuilder<Match> builder)
		{
			builder.ToTable("Matches");

			builder.HasKey(m => m.Id);

			builder.Property(m => m.Score)
				   .IsRequired();

			builder.Property(m => m.PlayedAt)
				   .HasDefaultValueSql("NOW()");

			builder.HasOne(m => m.Player)
				   .WithMany(p => p.Matches)
				   .HasForeignKey(m => m.PlayerId);
		}
	}
}
