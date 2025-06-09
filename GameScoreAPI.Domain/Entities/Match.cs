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

		public int Score { get; set; }
		public DateTime PlayedAt { get; set; }
	}
}
