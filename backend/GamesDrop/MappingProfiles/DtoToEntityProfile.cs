using AutoMapper;
using GamesDrop.Data.Entities;
using GamesDrop.Dtos;

namespace GamesDrop.MappingProfiles
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<UserDto, User>()
                .ForMember(dest => dest.UserName,
                    opt => opt.MapFrom(src => src.Email))
                .ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<GameDto, Game>();

            CreateMap<SaleDto, Sale>();
        }
    }
}