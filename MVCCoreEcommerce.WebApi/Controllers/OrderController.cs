using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var value = _orderService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            _orderService.TAdd(order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var value = _orderService.TGetByID(id);
            _orderService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            _orderService.TUpdate(order);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var value = _orderService.TGetByID(id);
            return Ok(value);
        }
    }
}
