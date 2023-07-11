using Microsoft.AspNetCore.Mvc;

namespace MVCCoreEcommerce.WebUI.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
