using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Queries.GetPlayerById
{
	public class GetPlayerByIdHandler : IRequestHandler<GetPlayerByIdQuery, GetPlayerByIdResponse>
	{
		private readonly IReadRepository<Domain.Entities.Player> _readRepository;
		private readonly IMapper _mapper;

		public GetPlayerByIdHandler(IReadRepository<Domain.Entities.Player> readRepository, IMapper mapper)
		{
			_readRepository = readRepository;
			_mapper = mapper;
		}

		public async Task<GetPlayerByIdResponse> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
		{
			var player = await _readRepository.GetByIdAsync(request.Id);
			return _mapper.Map<GetPlayerByIdResponse>(player);
		}
	}
}
