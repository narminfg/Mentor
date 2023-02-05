using Mentor.Models;
using Microsoft.EntityFrameworkCore;

namespace Mentor.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Course> courses { get; set; }
        public DbSet<Trainers> trainers { get; set; }
        public DbSet<EventsPage> eventspage { get; set; }
        public DbSet<Pricing> pricings { get; set; }
        public DbSet<About> about { get; set; }
        public DbSet<Contacts> contact { get; set; }


    }
}
