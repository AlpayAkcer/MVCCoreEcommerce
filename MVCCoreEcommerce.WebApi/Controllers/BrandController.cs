using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public IActionResult BrandList()
        {
            var value = _brandService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddBrand(Brand brand)
        {
            _brandService.TAdd(brand);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBrand(int id)
        {
            var value = _brandService.TGetByID(id);
            _brandService.TDelete(value);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.TUpdate(brand);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBrand(int id)
        {
            var value = _brandService.TGetByID(id);
            return Ok(value);
        }
    }
}
