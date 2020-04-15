using AutoMapper;
using BLL.ModelDto;
using DAL.Entities;

namespace BLL.Mapper
{
    public class MapperOrder : Profile
    {
        public MapperOrder()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
        }
    }
}