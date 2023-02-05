using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class TrainerController : Controller
    {
        private readonly AppDbContext _context;
        public TrainerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Trainers> trainers = _context.trainers.ToList();

            return View(trainers);
        }
    }
}
