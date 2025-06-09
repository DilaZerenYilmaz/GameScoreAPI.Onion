using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Queries.GetAllPlayers
{
	public class GetAllPlayersQueryResponse
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Score { get; set; }
	}

}
