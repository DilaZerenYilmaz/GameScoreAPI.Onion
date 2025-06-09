using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Matchs.Commands.Delete
{
	public class DeleteMatchCommand : IRequest<DeleteMatchResponse>
	{
		public Guid Id { get; set; }

		public DeleteMatchCommand(Guid id)
		{
			Id = id;
		}
	}
}
