using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialController : ControllerBase
    {
        private readonly ISocialService _socialService;

        public SocialController(ISocialService socialService)
        {
            _socialService = socialService;
        }

        [HttpGet]
        public IActionResult SocialList()
        {
            var value = _socialService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddSocial(Social social)
        {
            _socialService.TAdd(social);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocial(int id)
        {
            var value = _socialService.TGetByID(id);
            _socialService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSocial(Social social)
        {
            _socialService.TUpdate(social);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetSocial(int id)
        {
            var value = _socialService.TGetByID(id);
            return Ok(value);
        }
    }
}
