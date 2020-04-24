using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Interface;
using BLL.ModelDto;
using DAL.DAL_Core.Repository;
using DAL.EF;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace BLL.Repository
{
    public class UserBll : IUserBll
    {
        private readonly ApplicationContext _context = new ApplicationContext(new DbContextOptions<ApplicationContext>());
        private readonly DalFactory _dalFactory;
        private readonly IMapper _mapper;

        public UserBll(DalFactory dalFactory, IMapper mapper)
        {
            _dalFactory = dalFactory;
            _mapper = mapper;
        }

        public List<UserDto> GetAll()
        {
            List<UserDto> result = new List<UserDto>();
            var allUsers = _dalFactory.User.GetAll().Include(ord => ord.Order).ToList();
            foreach (var user in allUsers)
            {
                result.Add(new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    LastName = user.LastName,
                    DateBirthday = user.DateBirthday,
                    NumberLicense = user.NumberLicense
                });
            }

            return result;
        }

        public User GetById(int userId)
        {
            return _dalFactory.User.GetById(userId);
        }

        public void Add(UserDto user)
        {
            User result = _mapper.Map<UserDto, User>(user);
            _dalFactory.User.Add(result);
        }

        public void Update(UserDto user)
        {
            User result = _mapper.Map<UserDto, User>(user);
            _dalFactory.User.UpdateVoid(result, result.Id);
        }

        public void Delete(int userId)
        {
            User user = _context.Users.FirstOrDefault(x => x.Id == userId);
            _dalFactory.User.Delete(user);
            _context.SaveChanges();
        }
    }
}