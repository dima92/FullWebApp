using System.Collections.Generic;
using BLL.ModelDto;
using DAL.Entities;

namespace BLL.Interface
{
    public interface IUserBll
    {
        List<UserDto> GetAll();
        User GetById(int userId);
        void Add(UserDto user);
        void Update(UserDto user);
        void Delete(int userId);
    }
}