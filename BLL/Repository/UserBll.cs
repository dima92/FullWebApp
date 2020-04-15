using System.Collections.Generic;
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
            throw new System.NotImplementedException();
        }

        public User GetById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public void Add(UserDto user)
        {
            throw new System.NotImplementedException();
        }

        public void Update(UserDto user)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int userId)
        {
            throw new System.NotImplementedException();
        }
    }
}