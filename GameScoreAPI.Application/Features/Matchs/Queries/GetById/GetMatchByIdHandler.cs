using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using MediatR;

namespace GameScoreAPI.Application.Features.Matchs.Queries.GetById
{
	public class GetMatchByIdHandler : IRequestHandler<GetMatchByIdQuery, GetMatchByIdResponse>
	{
		private readonly IReadRepository<Match> _matchReadRepository;
		private readonly IMapper _mapper;

		public GetMatchByIdHandler(IReadRepository<Match> matchReadRepository, IMapper mapper)
		{
			_matchReadRepository = matchReadRepository;
			_mapper = mapper;
		}

		public async Task<GetMatchByIdResponse> Handle(GetMatchByIdQuery request, CancellationToken cancellationToken)
		{
			var match = await _matchReadRepository.GetByIdAsync(request.Id);
			return _mapper.Map<GetMatchByIdResponse>(match);
		}
	}
}
