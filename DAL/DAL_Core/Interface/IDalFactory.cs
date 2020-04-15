using DAL.GenericRepositoryModel.Interface;

namespace DAL.DAL_Core.Interface
{
    public interface IDalFactory
    {
        ICarDal Car { get; }
        IUserDal User { get; }
        IOrderDal Order { get; }
    }
}