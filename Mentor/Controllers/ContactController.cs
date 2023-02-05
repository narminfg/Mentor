using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Contacts> contact = _context.contact.ToList();

            return View(contact);
        }
    }
}
