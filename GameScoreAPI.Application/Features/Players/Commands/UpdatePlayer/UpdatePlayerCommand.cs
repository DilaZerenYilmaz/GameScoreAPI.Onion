using MediatR;

namespace GameScoreAPI.Application.Features.Players.Commands.UpdatePlayer
{
	public class UpdatePlayerCommand : IRequest<UpdatePlayerResponse>
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Score { get; set; }
	}
}
