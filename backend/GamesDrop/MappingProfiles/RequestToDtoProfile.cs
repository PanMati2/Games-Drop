using AutoMapper;
using GamesDrop.Contracts.Requests;
using GamesDrop.Dtos;

namespace GamesDrop.MappingProfiles
{
    public class RequestToDtoProfile : Profile
    {
        public RequestToDtoProfile()
        {
            CreateMap<RegisterRequest, UserDto>();
            CreateMap<CreateGameRequest, GameDto>();
            CreateMap<CreateSaleRequest, SaleDto>();
        }
    }
}