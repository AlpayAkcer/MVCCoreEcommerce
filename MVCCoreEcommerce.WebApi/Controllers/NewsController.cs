using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public IActionResult NewsList()
        {
            var value = _newsService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddNews(News news)
        {
            _newsService.TAdd(news);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNews(int id)
        {
            var value = _newsService.TGetByID(id);
            _newsService.TDelete(value);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateNews(News news)
        {
            _newsService.TUpdate(news);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetNews(int id)
        {
            var value = _newsService.TGetByID(id);
            return Ok(value);
        }
    }
}
