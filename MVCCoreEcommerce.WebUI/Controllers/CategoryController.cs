using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.Abstract;
using MVCCoreEcommerce.DataAccessLayer.Concrete;
using MVCCoreEcommerce.DtoLayer.Dto.CategoryDto;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading.Tasks;

namespace MVCCoreEcommerce.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAsync(Category model)
        {

            return View();
        }
    }
}
