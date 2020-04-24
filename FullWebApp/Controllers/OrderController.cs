using BLL.Infrastructure;
using BLL.Interface;
using BLL.ModelDto;
using Microsoft.AspNetCore.Mvc;
using System;

namespace FullWebApp.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IBllFactory _bllFactory;

        public OrderController(IBllFactory bllFactory)
        {
            _bllFactory = bllFactory ?? throw new ArgumentNullException(nameof(bllFactory));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var allOrders = _bllFactory.OrderBll.GetAll();
                return Ok(allOrders);

            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var result = _bllFactory.OrderBll.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Add(OrderDto order)
        {
            try
            {
                _bllFactory.OrderBll.Add(order);
                return Ok();
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError("error", ex.Message);
                return BadRequest(ModelState);
            }
        }

        [HttpPut]
        public IActionResult Update(OrderDto data)
        {
            try
            {
                _bllFactory.OrderBll.Update(data);
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
                _bllFactory.OrderBll.Delete(id);
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