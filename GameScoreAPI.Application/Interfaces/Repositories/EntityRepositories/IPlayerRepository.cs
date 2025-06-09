using GameScoreAPI.Domain.Entities;

namespace GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories
{
	public interface IPlayerRepository : IRepository<Player>
	{
		Task<Player?> GetPlayerByNameAsync(string name);
		Task<List<Player>> GetTopScoringPlayersAsync(int count);
	}
}
