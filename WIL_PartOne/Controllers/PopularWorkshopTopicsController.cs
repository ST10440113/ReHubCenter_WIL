using Microsoft.AspNetCore.Mvc;

namespace WIL_PartOne.Controllers
{
    public class PopularWorkshopTopicsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
