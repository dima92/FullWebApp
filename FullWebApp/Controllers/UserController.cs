using BLL.Infrastructure;
using BLL.Interface;
using BLL.ModelDto;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FullWebApp.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IBllFactory _bllFactory;
        public UserController(IBllFactory bllFactory)
        {
            _bllFactory = bllFactory ?? throw new ArgumentNullException(nameof(bllFactory));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var allUsers = _bllFactory.UserBll.GetAll();
                return Ok(allUsers);

            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var result = _bllFactory.UserBll.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(UserDto user)
        {
            try
            {
                _bllFactory.UserBll.Add(user);
                return Ok();
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public IActionResult Update(UserDto data)
        {
            try
            {
                _bllFactory.UserBll.Update(data);
                return Ok();
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _bllFactory.UserBll.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("warn", ex.Message);
                return BadRequest(ModelState);
            }
        }
    }
}