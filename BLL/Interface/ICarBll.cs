using System.Collections.Generic;
using System.Linq;
using BLL.ModelDto;
using DAL.Entities;

namespace BLL.Interface
{
    public interface ICarBll
    {
        List<CarDto> GetAll();
        Car GetById(int carId);
        void Add(CarDto car);
        void Update(CarDto car);
        void Delete(int carId);
    }
}