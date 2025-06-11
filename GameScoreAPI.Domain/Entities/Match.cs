using GameScoreAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Domain.Entities
{
	public class Match : BaseEntity
	{
		public Guid PlayerId { get; set; }
		public Player Player { get; set; } = null!;

		public ICollection<Player> Players { get; set; } = new List<Player>();
		public ICollection<PlayerMatchStats> MatchStats { get; set; } = new List<PlayerMatchStats>();
		public int TeamId { get; set; }
		public Team? Team { get; set; }

	}
}
