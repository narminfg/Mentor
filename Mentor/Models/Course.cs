namespace Mentor.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? TeacherImage { get; set; }
        public string? Teacher { get; set; }
        public int StudentCount { get; set; }
        public int Like { get; set;}
      

    }
}
