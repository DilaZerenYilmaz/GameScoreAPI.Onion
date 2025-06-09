using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Queries.GetPlayerById
{
	public class GetPlayerByIdResponse
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Score { get; set; }
	}
}
