using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using MediatR;

namespace GameScoreAPI.Application.Features.Matchs.Commands.Create
{
	public class CreateMatchHandler : IRequestHandler<CreateMatchCommand, CreateMatchResponse>
	{
		private readonly IWriteRepository<Match> _matchWriteRepository;
		public CreateMatchHandler(IWriteRepository<Match> matchWriteRepository)
		{
			_matchWriteRepository = matchWriteRepository;
		}
		public async Task<CreateMatchResponse> Handle(CreateMatchCommand request, CancellationToken cancellationToken)
		{
			var match = new Match
			{
				Id = Guid.NewGuid(),
				PlayerId = request.PlayerId,
				Score = request.Score,
				CreatedAt = DateTime.UtcNow
			};

			await _matchWriteRepository.AddAsync(match);

			return new CreateMatchResponse
			{
				Id = match.Id,
				Message = "Maç başarıyla eklendi!"
			};
		}
	}
}
