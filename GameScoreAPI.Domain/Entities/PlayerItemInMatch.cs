using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Domain.Entities
{
	public class PlayerItemInMatch
	{
		public int PlayerId { get; set; }
		public Player Player { get; set; } = new Player();

		public int MatchId { get; set; }
		public Match Match { get; set; } = new Match();

		public int ItemId { get; set; }
		public PlayerMatchStats Item { get; set; } = new PlayerMatchStats();
	}

}
