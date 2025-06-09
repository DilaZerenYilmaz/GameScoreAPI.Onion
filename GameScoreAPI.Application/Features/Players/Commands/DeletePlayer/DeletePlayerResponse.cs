using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Commands.DeletePlayer
{
	public class DeletePlayerResponse
	{
		public bool IsSuccess { get; set; }
		public string Message { get; set; } = string.Empty;
	}
}
