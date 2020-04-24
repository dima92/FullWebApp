using BLL.Infrastructure;
using BLL.Interface;
using BLL.ModelDto;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FullWebApp.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly IBllFactory _bllFactory;
        public CarController(IBllFactory bllFactory)
        {
            _bllFactory = bllFactory ?? throw new ArgumentNullException(nameof(bllFactory));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var allCars = _bllFactory.CarBll.GetAll();
                return Ok(allCars);

            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCar(int id)
        {
            var result = _bllFactory.CarBll.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(CarDto car)
        {
            try
            {
                _bllFactory.CarBll.Add(car);
                return Ok();
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public IActionResult Update(CarDto data)
        {
            try
            {
                _bllFactory.CarBll.Update(data);
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
                _bllFactory.CarBll.Delete(id);
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