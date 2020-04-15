using System.Collections.Generic;
using AutoMapper;
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
            throw new System.NotImplementedException();
        }

        public Order GetById(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(OrderDto order)
        {
            throw new System.NotImplementedException();
        }

        public void Update(OrderDto order)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int orderId)
        {
            throw new System.NotImplementedException();
        }
    }
}