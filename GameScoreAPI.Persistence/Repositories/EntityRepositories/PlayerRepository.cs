using GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories;
using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using GameScoreAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GameScoreAPI.Persistence.Repositories.EntityRepositories
{
	public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
	{
		private readonly GameScoreDbContext _context;

		public PlayerRepository(GameScoreDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<Player?> GetPlayerByNameAsync(string name)
		{
			return await _context.Players.FirstOrDefaultAsync(p => p.Name == name);
		}

		public async Task<List<Player>> GetTopScoringPlayersAsync(int count)
		{
			return await _context.Players
				.OrderByDescending(p => p.Score)
				.Take(count)
				.ToListAsync();
		}
	}
}
