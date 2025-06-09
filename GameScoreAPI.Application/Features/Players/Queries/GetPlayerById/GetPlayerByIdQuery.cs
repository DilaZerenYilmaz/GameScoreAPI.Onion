using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Queries.GetPlayerById
{
	public class GetPlayerByIdQuery : IRequest<GetPlayerByIdResponse>
	{
		public Guid Id { get; set; }

		public GetPlayerByIdQuery(Guid id)
		{
			Id = id;
		}
	}
}
