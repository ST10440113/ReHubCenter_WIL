using Microsoft.AspNetCore.Mvc;

namespace ReHubCenter_WIL.Controllers
{
    public class IndividualBookingController : Controller
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
