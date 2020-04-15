namespace BLL.Interface
{
    public interface IBllFactory
    {
        ICarBll CarBll { get; }
        IUserBll UserBll { get; }
        IOrderBll OrderBll { get; }
    }
}