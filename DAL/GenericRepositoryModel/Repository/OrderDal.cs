using DAL.DAL_Core.Interface;
using DAL.Entities;
using DAL.GenericRepository;
using DAL.GenericRepositoryModel.Interface;

namespace DAL.GenericRepositoryModel.Repository
{
    public class OrderDal : GenericRepository<Order>, IOrderDal
    {
        public OrderDal(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}