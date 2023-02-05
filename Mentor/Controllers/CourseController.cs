using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Course> courses = _context.courses.ToList();
            return View(courses);
        }
    }
}























