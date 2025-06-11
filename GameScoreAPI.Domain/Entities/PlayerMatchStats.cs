using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Domain.Entities
{
	public class PlayerMatchStats
	{
		public int PlayerId { get; set; }
		public Player Player { get; set; } = new Player();

		public int MatchId { get; set; }
		public Match Match { get; set; } = new Match();

		public int Kills { get; set; }
		public int Deaths { get; set; }
		public int Assists { get; set; }

		public bool IsWinner { get; set; }
		public string PlayedCharacter { get; set; } = string.Empty;

		public ICollection<PlayerItemInMatch> Items { get; set; } = new List<PlayerItemInMatch>();
	}

}
