using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories;
using GameScoreAPI.Domain.Entities;
using MediatR;

namespace GameScoreAPI.Application.Features.Players.Commands.CreatePlayer
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, CreatePlayerResponse>
	{
		private readonly IWriteRepository<Player> _writeRepository;
		private readonly IMapper _mapper;

		public CreatePlayerCommandHandler(IWriteRepository<Player> writeRepository, IMapper mapper)
		{
			_writeRepository = writeRepository;
			_mapper = mapper;
		}

		public async Task<CreatePlayerResponse> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
		{
			var player = _mapper.Map<Player>(request);
			await _writeRepository.AddAsync(player);

			var response = _mapper.Map<CreatePlayerResponse>(player);
			return response;
		}
	}
}
