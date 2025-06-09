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
		}
	}
}
