using AutoMapper;
using GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories;
using MediatR;


namespace GameScoreAPI.Application.Features.Players.Commands.UpdatePlayer
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand, UpdatePlayerResponse>
	{
		private readonly IPlayerRepository _playerRepository;
		private readonly IMapper _mapper;

		public UpdatePlayerCommandHandler(IPlayerRepository playerRepository, IMapper mapper)
		{
			_playerRepository = playerRepository;
			_mapper = mapper;
		}

		public async Task<UpdatePlayerResponse> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
		{
			var player = await _playerRepository.GetByIdAsync(request.Id);
			if (player == null)
				throw new Exception("Oyuncu bulunamadı");

			// Güncelleme işlemleri
			player.Name = request.Name;
			player.Score = request.Score;

			await _playerRepository.UpdateAsync(player);
			await _playerRepository.SaveChangesAsync();

			var response = _mapper.Map<UpdatePlayerResponse>(player);
			return response;
		}
	}
}
