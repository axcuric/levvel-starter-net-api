using AutoMapper;
using LvvlStarterNetApi.Core.Dtos;
using LvvlStarterNetApi.Core.Models;
using System.Linq;

namespace LvvlStarterNetApi.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(c => c.PhoneNumber,
                 opt => opt.MapFrom(x => x.Phones.Select(n => n.PhoneNumber).FirstOrDefault()));
        }
    }
}