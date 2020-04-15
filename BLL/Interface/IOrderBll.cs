using System.Collections.Generic;
using BLL.ModelDto;
using DAL.Entities;

namespace BLL.Interface
{
    public interface IOrderBll
    {
        List<OrderDto> GetAll();
        Order GetById(int orderId);
        void Add(OrderDto order);
        void Update(OrderDto order);
        void Delete(int orderId);
    }
}