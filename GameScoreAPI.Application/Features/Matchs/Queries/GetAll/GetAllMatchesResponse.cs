using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Matchs.Queries.GetAll
{
	public class GetAllMatchesResponse
	{
		public Guid Id { get; set; }
		public Guid PlayerId { get; set; }
		public int Score { get; set; }
		public DateTime PlayedAt { get; set; }
	}
}
