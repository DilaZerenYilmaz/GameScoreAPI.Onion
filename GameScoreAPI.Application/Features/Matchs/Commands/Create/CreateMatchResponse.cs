
namespace GameScoreAPI.Application.Features.Matchs.Commands.Create
{
	public class CreateMatchResponse
	{
		public Guid Id { get; set; }
		public string Message { get; set; } = string.Empty;
	}
}
