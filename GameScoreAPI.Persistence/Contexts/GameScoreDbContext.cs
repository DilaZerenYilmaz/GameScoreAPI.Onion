using GameScoreAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Persistence.Contexts
{
	public class GameScoreDbContext : DbContext
	{
		public GameScoreDbContext(DbContextOptions<GameScoreDbContext> options)
		: base(options) { }

		public DbSet<Player> Players { get; set; }
		public DbSet<Match> Matches { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(GameScoreDbContext).Assembly);
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Ability>()
				.HasOne(a => a.Player)
				.WithMany(p => p.Abilities)
				.HasForeignKey(a => a.PlayerId);

			modelBuilder.Entity<Match>()
				.HasOne(m => m.Team)
				.WithMany(t => t.Matches)
				.HasForeignKey(m => m.TeamId);

			modelBuilder.Entity<Player>()
				.HasOne(p => p.Team)
				.WithMany(t => t.Players)
				.HasForeignKey(p => p.TeamId);

			modelBuilder.Entity<Ability>()
				.HasOne(a => a.Player)
				.WithMany(p => p.Abilities)
				.HasForeignKey(a => a.PlayerId);

			modelBuilder.Entity<PlayerMatchStats>()
				.HasKey(pms => new { pms.PlayerId, pms.MatchId });

			modelBuilder.Entity<PlayerMatchStats>()
				.HasOne(pms => pms.Player)
				.WithMany(p => p.MatchStats)
				.HasForeignKey(pms => pms.PlayerId);

			modelBuilder.Entity<PlayerMatchStats>()
				.HasOne(pms => pms.Match)
				.WithMany(m => m.MatchStats)
				.HasForeignKey(pms => pms.MatchId);

			modelBuilder.Entity<PlayerItemInMatch>()
				.HasOne(pi => pi.Item)
				.WithMany(pms => pms.Items)
				.HasForeignKey(pi => new { pi.PlayerId, pi.MatchId });

		}
	}
}
