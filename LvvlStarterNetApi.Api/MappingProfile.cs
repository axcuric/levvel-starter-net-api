using AutoMapper;
using LvvlStarterNetApi.Core.Dtos;
using LvvlStarterNetApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LvvlStarterNetApi.Api
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
        }
    }
}
