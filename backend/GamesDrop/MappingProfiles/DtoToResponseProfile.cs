using AutoMapper;
using GamesDrop.Contracts.Responses;
using GamesDrop.Dtos;

namespace GamesDrop.MappingProfiles
{
    public class DtoToResponseProfile : Profile
    {
        public DtoToResponseProfile()
        {
            CreateMap<UserDto, LoginResponse>();
        }
    }
}