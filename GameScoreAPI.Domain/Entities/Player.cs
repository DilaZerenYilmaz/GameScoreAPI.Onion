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

		public ICollection<Match> Matches { get; set; } = new List<Match>();
	}
}
