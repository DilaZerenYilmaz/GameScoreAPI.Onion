using MediatR;

namespace GameScoreAPI.Application.Features.Players.Commands.CreatePlayer
{
	public class CreatePlayerCommand : IRequest<CreatePlayerResponse>
	{
		public string Name { get; set; } = string.Empty;
		public int Score { get; set; }
	}
}
