
namespace GameScoreAPI.Application.Features.Players.Commands.UpdatePlayer
{
	public class UpdatePlayerResponse
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Score { get; set; }
	}
}
