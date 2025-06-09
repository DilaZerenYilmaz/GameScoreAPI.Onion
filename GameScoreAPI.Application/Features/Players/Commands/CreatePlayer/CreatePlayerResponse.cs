
namespace GameScoreAPI.Application.Features.Players.Commands.CreatePlayer
{
	public class CreatePlayerResponse
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Score { get; set; }
	}
}
