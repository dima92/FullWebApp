using DAL.DAL_Core.Interface;
using DAL.Entities;
using DAL.GenericRepository;
using DAL.GenericRepositoryModel.Interface;

namespace DAL.GenericRepositoryModel.Repository
{
    public class CarDal : GenericRepository<Car>, ICarDal
    {
        public CarDal(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}