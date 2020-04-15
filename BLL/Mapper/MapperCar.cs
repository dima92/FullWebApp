using AutoMapper;
using BLL.ModelDto;
using DAL.Entities;

namespace BLL.Mapper
{
    public class MapperCar : Profile
    {
        public MapperCar()
        {
            CreateMap<Car, CarDto>();
            CreateMap<CarDto, Car>();
        }
    }
}