using GameScoreAPI.Application.Features.Matchs.Commands.Update;
using MediatR;

namespace Application.Features.Match.Commands.Update
{
	public class UpdateMatchCommand : IRequest<UpdateMatchResponse>
	{
		public Guid Id { get; set; }
		public Guid PlayerId { get; set; }
		public int Score { get; set; }
		public DateTime PlayedAt { get; set; }

		public UpdateMatchCommand(Guid id, Guid playerId, int score, DateTime playedAt)
		{
			Id = id;
			PlayerId = playerId;
			Score = score;
			PlayedAt = playedAt;
		}
	}
}

