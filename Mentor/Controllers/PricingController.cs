using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            List<Pricing> pricings = _context.pricings.ToList();

            return View(pricings);
        }
    }
}
