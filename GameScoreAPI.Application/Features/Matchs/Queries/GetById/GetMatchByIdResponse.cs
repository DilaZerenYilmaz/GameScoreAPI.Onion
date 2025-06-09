
namespace GameScoreAPI.Application.Features.Matchs.Queries.GetById
{
    public class GetMatchByIdResponse
    {
        public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public int Score { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
