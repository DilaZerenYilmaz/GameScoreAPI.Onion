using AutoMapper;
using GameScoreAPI.Application.Features.Matchs.Queries.GetAll;
using GameScoreAPI.Application.Features.Matchs.Queries.GetById;
using GameScoreAPI.Domain.Entities;

namespace GameScoreAPI.Application.MappingProfiles
{
	public class MatchMappingProfile : Profile
	{
		public MatchMappingProfile()
		{
			CreateMap<Match, GetMatchByIdResponse>().ReverseMap();
			CreateMap<Match, GetAllMatchesResponse>().ReverseMap();
		}
	}
}
