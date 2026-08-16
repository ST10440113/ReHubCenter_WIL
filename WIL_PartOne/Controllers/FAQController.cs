using Microsoft.AspNetCore.Mvc;

namespace WIL_PartOne.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
