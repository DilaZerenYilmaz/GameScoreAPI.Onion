using GameScoreAPI.Application.Interfaces.Repositories.EntityRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScoreAPI.Application.Features.Players.Commands.DeletePlayer
{
	public class DeletePlayerHandler : IRequestHandler<DeletePlayerCommand, DeletePlayerResponse>
	{
		private readonly IPlayerRepository _playerRepository;

		public DeletePlayerHandler(IPlayerRepository playerRepository)
		{
			_playerRepository = playerRepository;
		}

		public async Task<DeletePlayerResponse> Handle(DeletePlayerCommand request, CancellationToken cancellationToken)
		{
			var player = await _playerRepository.GetByIdAsync(request.Id);

			if (player == null)
			{
				return new DeletePlayerResponse
				{
					IsSuccess = false,
					Message = "Player not found"
				};
			}

			await _playerRepository.DeleteAsync(player);

			return new DeletePlayerResponse
			{
				IsSuccess = true,
				Message = "Player deleted successfully"
			};
		}
	}

}
