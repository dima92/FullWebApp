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
    public class CarBll : ICarBll
    {
        private readonly ApplicationContext _context = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        private readonly DalFactory _dalFactory;
        private readonly IMapper _mapper;

        public CarBll(DalFactory dalFactory, IMapper mapper)
        {
            _dalFactory = dalFactory;
            _mapper = mapper;
        }

        public List<CarDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Car GetById(int carId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(CarDto car)
        {
            throw new System.NotImplementedException();
        }

        public void Update(CarDto car)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int carId)
        {
            throw new System.NotImplementedException();
        }
    }
}