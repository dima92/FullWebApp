using System.Collections.Generic;
using System.Linq;
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
            List<CarDto> result = new List<CarDto>();
            var allCars = _dalFactory.Car.GetAll().Include(ord => ord.Order).ToList();
            foreach (var car in allCars)
            {
                result.Add(new CarDto
                {
                    Id = car.Id,
                    Model = car.Model,
                    Mark = car.Mark,
                    ClassCar = car.ClassCar,
                    DateManufacture = car.DateManufacture,
                    NumberRegistration = car.NumberRegistration
                });
            }

            return result;
        }

        public Car GetById(int carId)
        {
            return _dalFactory.Car.GetById(carId);
        }

        public void Add(CarDto car)
        {
            Car result = _mapper.Map<CarDto, Car>(car);
            _dalFactory.Car.Add(result);
        }

        public void Update(CarDto car)
        {
            Car result = _mapper.Map<CarDto, Car>(car);
            _dalFactory.Car.UpdateVoid(result, result.Id);
        }

        public void Delete(int carId)
        {
            Car car = _context.Cars.FirstOrDefault(x => x.Id == carId);
            _dalFactory.Car.Delete(car);
            _context.SaveChanges();
        }
    }
}