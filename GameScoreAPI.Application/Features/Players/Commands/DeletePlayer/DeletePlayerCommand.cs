using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Commands.DeletePlayer
{
	public class DeletePlayerCommand : IRequest<DeletePlayerResponse>
	{
		public Guid Id { get; set; }

		public DeletePlayerCommand(Guid id)
		{
			Id = id;
		}
	}
}
