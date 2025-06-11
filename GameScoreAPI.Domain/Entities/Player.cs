using GameScoreAPI.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Domain.Entities
{
	public class Player : BaseEntity
	{
		public string Name { get; set; } = null!;
		public int Score { get; set; }

		public ICollection<Ability> Abilities { get; set; } = new List<Ability>();
		public ICollection<Item> Items { get; set; } = new List<Item>();

		public ICollection<Match> Matches { get; set; } = new List<Match>();
		public ICollection<PlayerMatchStats> MatchStats { get; set; } = new List<PlayerMatchStats>();

		public int TeamId { get; set; }
		public Team Team { get; set; } = new Team();
	}
}
