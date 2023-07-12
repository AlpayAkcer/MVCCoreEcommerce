using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogContentController : ControllerBase
    {
        private readonly IBlogContentService _blogContentService;

        public BlogContentController(IBlogContentService blogContentService)
        {
            _blogContentService = blogContentService;
        }

        [HttpGet]
        public IActionResult BlogContentList()
        {
            var value = _blogContentService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddBlogContent(BlogContent blogContent)
        {
            _blogContentService.TAdd(blogContent);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlogContent(int id)
        {
            var value = _blogContentService.TGetByID(id);
            _blogContentService.TDelete(value);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBlogContent(BlogContent blogContent)
        {
            _blogContentService.TUpdate(blogContent);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogContent(int id)
        {
            var value = _blogContentService.TGetByID(id);
            return Ok(value);
        }
    }
}
