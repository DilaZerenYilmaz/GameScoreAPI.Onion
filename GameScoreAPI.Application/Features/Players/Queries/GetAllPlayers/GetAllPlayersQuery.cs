using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Queries.GetAllPlayers
{
	public class GetAllPlayersQuery : IRequest<List<GetAllPlayersQueryResponse>>
	{
	}
}
