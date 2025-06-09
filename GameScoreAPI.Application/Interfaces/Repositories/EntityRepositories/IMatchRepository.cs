using GameScoreAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories
{
	public interface IMatchRepository : IRepository<Match>
	{
		Task<List<Match>> GetRecentMatchesByPlayerIdAsync(Guid playerId, int count);
		Task<double> GetAverageScoreAsync(Guid playerId);
		Task<List<Match>> GetTopScoresAsync(int topN);
	}
}
