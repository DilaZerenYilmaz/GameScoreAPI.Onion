using GameScoreAPI.Application.Features.Matchs.Commands.Create;
using MediatR;

namespace GameScoreAPI.Application.Features.Matchs.Commands
{
	public class CreateMatchCommand : IRequest<CreateMatchResponse>
	{
		public Guid PlayerId { get; set; }
		public int Score { get; set; }
	}
}
