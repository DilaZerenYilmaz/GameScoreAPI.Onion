using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Matchs.Commands.Update
{
	public class UpdateMatchResponse
	{
		public Guid Id { get; set; }
		public string Message { get; set; } = string.Empty;
	}
}
