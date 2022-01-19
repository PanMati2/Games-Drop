using AutoMapper;
using GamesDrop.Data.Entities;
using GamesDrop.Dtos;

namespace GamesDrop.MappingProfiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<GameCategory, GameCategoryDto>();
        }
    }
}