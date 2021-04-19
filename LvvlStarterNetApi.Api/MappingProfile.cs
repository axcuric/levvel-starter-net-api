using AutoMapper;
using LvvlStarterNetApi.Core.Dtos;
using LvvlStarterNetApi.Core.Models;

namespace LvvlStarterNetApi.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}