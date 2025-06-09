using GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories;
using GameScoreAPI.Domain.Entities;
using GameScoreAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Persistence.Repositories.EntityRepositories
{
	public class MatchRepository : GenericRepository<Match>, IMatchRepository
	{
		private readonly GameScoreDbContext _context;

		public MatchRepository(GameScoreDbContext context) : base(context)
		{
			_context = context;
		}

		public async Task<List<Match>> GetRecentMatchesByPlayerIdAsync(Guid playerId, int count)
		{
			return await _context.Matches
				.Where(m => m.PlayerId == playerId)
				.OrderByDescending(m => m.CreatedAt)
				.Take(count)
				.ToListAsync();
		}

		public async Task<double> GetAverageScoreAsync(Guid playerId)
		{
			return await _context.Matches
				.Where(m => m.PlayerId == playerId)
				.AverageAsync(m => m.Score);
		}

		public async Task<List<Match>> GetTopScoresAsync(int topN)
		{
			return await _context.Matches
				.OrderByDescending(m => m.Score)
				.Take(topN)
				.ToListAsync();
		}
	}
}
