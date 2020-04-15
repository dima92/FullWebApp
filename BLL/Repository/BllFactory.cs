using AutoMapper;
using BLL.Interface;
using DAL.DAL_Core.Repository;

namespace BLL.Repository
{
    public class BllFactory : IBllFactory
    {
        private readonly DalFactory _dalFactory;
        private readonly IMapper _mapper;

        private ICarBll _carBll;
        private IUserBll _userBll;
        private IOrderBll _orderBll;

        public BllFactory(IMapper mapper)
        {
            _mapper = mapper;
            _dalFactory = new DalFactory(new DbFactory());
        }

        public ICarBll CarBll => _carBll ??= new CarBll(_dalFactory, _mapper);
        public IUserBll UserBll => _userBll ??= new UserBll(_dalFactory, _mapper);
        public IOrderBll OrderBll => _orderBll ??= new OrderBll(_dalFactory, _mapper);
    }
}