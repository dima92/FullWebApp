using DAL.DAL_Core.Interface;
using DAL.EF;
using DAL.GenericRepositoryModel.Interface;
using DAL.GenericRepositoryModel.Repository;

namespace DAL.DAL_Core.Repository
{
    public class DalFactory : IDalFactory
    {
        private ICarDal _car;
        private IUserDal _user;
        private IOrderDal _order;

        private ApplicationContext _dbContext;
        private readonly IDbFactory _dbFactory;

        public DalFactory(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public ApplicationContext DbContext => _dbContext ??= _dbFactory.Init();

        public ICarDal Car => _car ??= new CarDal(_dbFactory);
        public IUserDal User => _user ??= new UserDal(_dbFactory);
        public IOrderDal Order => _order ??= new OrderDal(_dbFactory);

    }
}