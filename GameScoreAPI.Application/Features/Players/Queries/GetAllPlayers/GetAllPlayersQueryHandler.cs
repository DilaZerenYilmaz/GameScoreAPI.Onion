using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Queries.GetAllPlayers
{
    public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, List<GetAllPlayersQueryResponse>>
	{
		private readonly IReadRepository<Player> _readRepository;
		private readonly IMapper _mapper;

		public GetAllPlayersQueryHandler(IReadRepository<Player> readRepository, IMapper mapper)
		{
			_readRepository = readRepository;
			_mapper = mapper;
		}

		public async Task<List<GetAllPlayersQueryResponse>> Handle(GetAllPlayersQuery request, CancellationToken cancellationToken)
		{
			var players = await _readRepository.GetAllAsync();
			return _mapper.Map<List<GetAllPlayersQueryResponse>>(players);
		}
	}

}
