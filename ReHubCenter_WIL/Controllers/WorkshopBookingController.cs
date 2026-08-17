using Microsoft.AspNetCore.Mvc;

namespace ReHubCenter_WIL.Controllers
{
    public class WorkshopBookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
