using Microsoft.AspNetCore.Mvc;
using MVCCoreEcommerce.BusinessLayer.Concrete;
using MVCCoreEcommerce.DataAccessLayer.EntityFramework;

namespace MVCCoreEcommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaxController : Controller
    {
        TaxManager taxManager = new TaxManager(new EfTaxDal());
        public IActionResult Index()
        {
            return View();
        }
    }
}
