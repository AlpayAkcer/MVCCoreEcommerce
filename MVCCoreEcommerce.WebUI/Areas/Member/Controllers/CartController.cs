using Microsoft.AspNetCore.Mvc;

namespace MVCCoreEcommerce.WebUI.Areas.Member.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
