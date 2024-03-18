using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using System.Xml.Linq;

namespace MvcBlog.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public bool IsMarried { get; set; }
        public char Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public float Weight { get; set; }
        public decimal Salary { get; set; }
        public long IDNumber { get; set; }
        public short ChildrenCount { get; set; }
        public byte NumberOfPets { get; set; }
        public bool IsActive { get; set; }

        public Person(int id, string name, int age, double height, bool isMarried, char gender, DateTime birthdate,
            float weight, decimal salary, long idNumber, short childrenCount, byte numberOfPets, bool isActive)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.IsMarried = isMarried; 
            this.Gender = gender;
            this.BirthDate = birthdate;
            this.Weight = weight;
            this.Salary = salary;
            this.IDNumber = idNumber;
            this.ChildrenCount= childrenCount;
            this.NumberOfPets = numberOfPets;
            this.IsActive = isActive;              
        }
    }
}
