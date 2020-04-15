using DAL.EF;

namespace DAL.DAL_Core.Interface
{
    public interface IDbFactory
    {
        ApplicationContext Init();
    }
}