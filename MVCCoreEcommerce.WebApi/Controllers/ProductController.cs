using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.DtoLayer.Dto.ProductDto;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        //private readonly IMapper _mapper;

        public ProductController(IProductService productService/*, IMapper mapper*/)
        {
            _productService = productService;
            //_mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _productService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.TAdd(product);
            return Ok(product);

            //DTO kullanılacak olursa eğer, o zaman devreye automapper giriyor. ve kullanımı aşağıdaki gibi olmalı.
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}
            //var value = _mapper.Map<Product>(product);
            //_productService.TAdd(value);
            //return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetByID(id);
            _productService.TDelete(values);
            return Ok();
        }

        [HttpPut] //Update Kısmı
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);

            //DTO kullanılacak olursa eğer, o zaman devreye automapper giriyor. ve kullanımı aşağıdaki gibi olmalı.
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest();
            //}
            //var value = _mapper.Map<Product>(product);
            //_productService.TUpdate(value);
            return Ok("İşlem Başarılı");
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetByID(id);
            return Ok(values);
        }
    }
}
