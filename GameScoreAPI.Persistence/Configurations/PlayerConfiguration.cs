using GameScoreAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Persistence.Configurations
{
	public class PlayerConfiguration : IEntityTypeConfiguration<Player>
	{
		public void Configure(EntityTypeBuilder<Player> builder)
		{
			builder.ToTable("Players");

			builder.HasKey(p => p.Id);

			builder.Property(p => p.Name)
				   .IsRequired()
				   .HasMaxLength(50);

			builder.Property(p => p.Score)
				   .HasDefaultValue(0);

			builder.Property(p => p.CreatedAt)
				   .HasDefaultValueSql("NOW()"); // PostgreSQL için

			builder.Property(p => p.UpdatedAt)
				   .HasDefaultValueSql("NOW()");
		}
	}
}
