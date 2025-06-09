using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Matchs.Queries.GetAll
{
	public class GetAllMatchesQuery : IRequest<List<GetAllMatchesResponse>>
	{
	}
}
