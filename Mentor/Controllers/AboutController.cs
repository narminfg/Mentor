using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<About> about = _context.about.ToList();

            return View(about);
        }
    }
}
