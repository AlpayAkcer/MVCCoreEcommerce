using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.EntityLayer.Concrete;

namespace MVCCoreEcommerce.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCategoryController : ControllerBase
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogCategoryController(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        [HttpGet]
        public IActionResult BlogCategoryList()
        {
            var value = _blogCategoryService.TGetList();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult AddBlogCategory(BlogCategory blogCategory)
        {
            _blogCategoryService.TAdd(blogCategory);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlogCategory(int id)
        {
            var value = _blogCategoryService.TGetByID(id);
            _blogCategoryService.TDelete(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBlogCategory(BlogCategory blogCategory)
        {
            _blogCategoryService.TUpdate(blogCategory);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBlogCategory(int id)
        {
            var value = _blogCategoryService.TGetByID(id);
            return Ok(value);
        }
    }
}
