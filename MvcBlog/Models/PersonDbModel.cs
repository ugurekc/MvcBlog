using Microsoft.EntityFrameworkCore;

namespace MvcBlog.Models
{
    public class PersonDbModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public int Salary { get; set; }
        public int IDNumber { get; set; }
        public int ChildrenCount { get; set; }
        public int NumberOfPets { get; set; }
        public bool IsActive { get; set; }
    }
}
