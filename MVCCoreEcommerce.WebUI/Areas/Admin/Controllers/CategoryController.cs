using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Abstract;
using MVCCoreEcommerce.DtoLayer.Dto.CategoryDto;
using MVCCoreEcommerce.EntityLayer.Concrete;
using System;

namespace MVCCoreEcommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

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
        public IActionResult AddCategory(CategoryAddDto model)
        {
            if (ModelState.IsValid)
            {
                _categoryService.TAdd(new Category()
                {
                    Name = model.Name,
                    Description = model.Description,
                    Picture = "test.jpg",
                    IsStatus = true
                });

                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
