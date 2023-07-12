using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly ITaxService _taxService;

        public TaxController(ITaxService taxService)
        {
            _taxService = taxService;
        }

        [HttpGet]
        public IActionResult TaxList()
        {
            var value = _taxService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddTax(Tax tax)
        {
            _taxService.TAdd(tax);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTax(int id)
        {
            var value = _taxService.TGetByID(id);
            _taxService.TDelete(value);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTax(Tax tax)
        {
            _taxService.TUpdate(tax);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTax(int id)
        {
            var value = _taxService.TGetByID(id);
            return Ok(value);
        }
    }
}
