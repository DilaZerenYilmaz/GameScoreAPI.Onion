using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories;
using MediatR;

namespace GameScoreAPI.Application.Features.Matchs.Queries.GetAll
{
	public class GetAllMatchesHandler : IRequestHandler<GetAllMatchesQuery, List<GetAllMatchesResponse>>
	{
		private readonly IMatchRepository _matchRepository;
		private readonly IMapper _mapper;

		public GetAllMatchesHandler(IMatchRepository matchRepository, IMapper mapper)
		{
			_matchRepository = matchRepository;
			_mapper = mapper;
		}

		public async Task<List<GetAllMatchesResponse>> Handle(GetAllMatchesQuery request, CancellationToken cancellationToken)
		{
			var matches = await _matchRepository.GetAllAsync();
			return _mapper.Map<List<GetAllMatchesResponse>>(matches);
		}
	}
}
