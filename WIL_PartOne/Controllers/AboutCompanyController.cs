using Microsoft.AspNetCore.Mvc;

namespace WIL_PartOne.Controllers
{
    public class AboutCompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
