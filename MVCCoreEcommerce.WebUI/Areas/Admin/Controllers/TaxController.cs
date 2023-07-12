using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Concrete;
using MVCCoreEcommerce.DataAccessLayer.EntityFramework;

namespace MVCCoreEcommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaxController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }
    }
}
