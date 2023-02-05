using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class EventPageController : Controller
    {
        private readonly AppDbContext _context;
        public EventPageController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            List<EventsPage> eventspage = _context.eventspage.ToList();

            return View(eventspage);
        }
    }
}
