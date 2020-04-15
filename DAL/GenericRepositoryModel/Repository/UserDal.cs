using DAL.DAL_Core.Interface;
using DAL.Entities;
using DAL.GenericRepository;
using DAL.GenericRepositoryModel.Interface;

namespace DAL.GenericRepositoryModel.Repository
{
    public class UserDal : GenericRepository<User>, IUserDal
    {
        public UserDal(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}