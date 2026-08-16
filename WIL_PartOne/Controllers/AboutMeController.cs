using Microsoft.AspNetCore.Mvc;

namespace WIL_PartOne.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
