using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
