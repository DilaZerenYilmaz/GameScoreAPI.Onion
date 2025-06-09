using AutoMapper;
using GameScoreAPI.Application.Features.Players.Commands.CreatePlayer;
using GameScoreAPI.Application.Features.Players.Queries.GetPlayerById;
using GameScoreAPI.Domain.Entities;

namespace GameScoreAPI.Application.MappingProfiles
{
	internal class PlayerMappingProfile : Profile
	{
		public PlayerMappingProfile()
		{
			CreateMap<CreatePlayerCommand, Player>().ReverseMap();
			CreateMap<Player, CreatePlayerResponse>().ReverseMap();
			CreateMap<Player, GetPlayerByIdResponse>().ReverseMap();
		}
	}
}
