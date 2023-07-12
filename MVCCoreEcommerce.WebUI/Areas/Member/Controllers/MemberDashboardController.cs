using Microsoft.AspNetCore.Mvc;

namespace MVCCoreEcommerce.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
