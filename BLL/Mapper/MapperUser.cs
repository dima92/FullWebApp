using AutoMapper;
using BLL.ModelDto;
using DAL.Entities;

namespace BLL.Mapper
{
    public class MapperUser : Profile
    {
        public MapperUser()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}