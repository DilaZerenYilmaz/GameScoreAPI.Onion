using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Domain.Entities
{
	public class Team
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty; // Red or Blue
		public bool IsWinner { get; set; }

		public ICollection<Player> Players { get; set; } = new List<Player>();
		public ICollection<Match> Matches { get; set; } = new List<Match>();
	}

}
