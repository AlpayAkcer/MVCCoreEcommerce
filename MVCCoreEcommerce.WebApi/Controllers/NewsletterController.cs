using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsletterController : ControllerBase
    {
        private readonly INewsletterService _newsletterService;

        public NewsletterController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet]
        public IActionResult NewsletterList()
        {
            var value = _newsletterService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddNewsletter(Newsletter newsletter)
        {
            _newsletterService.TAdd(newsletter);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNewsletter(int id)
        {
            var value = _newsletterService.TGetByID(id);
            _newsletterService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateNewsletter(Newsletter newsletter)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetNewsletter(int id)
        {
            var value = _newsletterService.TGetByID(id);
            return Ok(value);
        }
    }
}
