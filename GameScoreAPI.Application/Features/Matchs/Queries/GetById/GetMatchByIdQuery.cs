using MediatR;

namespace GameScoreAPI.Application.Features.Matchs.Queries.GetById
{
    public class GetMatchByIdQuery : IRequest<GetMatchByIdResponse>
    {
        public Guid Id { get; set; }

		public GetMatchByIdQuery(Guid id)
		{
			Id = id;
		}
	}

}
