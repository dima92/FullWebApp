using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Infrastructure;
using BLL.Interface;
using BLL.ModelDto;
using DAL.DAL_Core.Repository;
using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repository
{
    public class OrderBll : IOrderBll
    {
        private readonly ApplicationContext _context = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        private readonly DalFactory _dalFactory;
        private readonly IMapper _mapper;

        public OrderBll(DalFactory dalFactory, IMapper mapper)
        {
            _dalFactory = dalFactory;
            _mapper = mapper;
        }

        public List<OrderDto> GetAll()
        {
            List<OrderDto> result = new List<OrderDto>();
            var allOrders = _dalFactory.Order.GetAll().Include(c => c.Car).Include(us => us.User).ToList();
            foreach (var order in allOrders)
            {
                result.Add(new OrderDto
                {
                    Id = order.Id,
                    Car = $"{order.Car.Mark} {order.Car.Model}",
                    CarId = order.CarId,
                    User = $"{order.User.Name} {order.User.LastName}",
                    UserId = order.UserId,
                    StartDate = order.StartDate,
                    EndDate = order.EndDate,
                    Rent = order.Rent,
                    Description = order.Description
                });
            }

            return result.OrderByDescending(x => x.StartDate).ToList();
        }

        public Order GetById(int orderId)
        {
            return _dalFactory.Order.GetById(orderId);
        }

        public void Add(OrderDto order)
        {
            Order result = _mapper.Map<OrderDto, Order>(order);
            _dalFactory.Order.Add(result);
        }

        public void Update(OrderDto order)
        {
            Order ord = new Order();
            ord.CarId = order.CarId;
            ord.UserId = order.UserId;
            ord.Description = order.Description;
            ord.StartDate = order.StartDate;
            ord.EndDate = order.EndDate;
            ord.Rent = order.Rent;
            ord.Id = order.Id;
            _dalFactory.Order.UpdateVoid(ord, ord.Id);
            _context.SaveChanges();
        }

        public void Delete(int orderId)
        {
            Order order = _context.Orders.FirstOrDefault(x => x.Id == orderId);
            _dalFactory.Order.Delete(order);
            _context.SaveChanges();
        }
    }
}