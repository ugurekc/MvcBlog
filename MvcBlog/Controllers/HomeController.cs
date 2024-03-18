using Microsoft.AspNetCore.Mvc;
using MvcBlog.Models;
using MvcBlog.ViewModels;
using System.Diagnostics;
using System.Linq;


namespace MvcBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PersonelContext _context;

        public HomeController(ILogger<HomeController> logger, PersonelContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            PersonDbViewModel pdvm = new();
            pdvm.Persons=_context.Person.ToList();

            PersonDbModel p = new();
            pdvm.OnePerson = p;

            return View(pdvm);
        }
       
        
        [HttpPost]
        public IActionResult Insert(PersonDbModel pdm)
        {
            pdm.IsActive = true;

            _context.Add(pdm);
            _context.SaveChanges();


            //@TempData["alertMsg"] = "Personel saved succesfully.";

            return RedirectToAction("Index");
        }

        public IActionResult UpdatePage(PersonDbModel pdm)
        {
            PersonDbViewModel pdvm = new();
            pdvm.Persons = _context.Person.ToList();

            PersonDbModel p = new();
            p = _context.Person.First(x => x.Id == pdm.Id);
            pdvm.OnePerson = p;

            return View(pdvm);
        }

        [HttpPost]
        public IActionResult Update(PersonDbModel pdm)
        {
            pdm.IsActive = true;
            _context.Update(pdm);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(PersonDbModel pdm)
        {
            _context.Remove(pdm);
            _context.SaveChanges();
            //@TempData["alertMsg"] = "Personel saved succesfully.";

            return RedirectToAction("Index");
        }

        public static List<Person> createPerson(int count)
        {
            List<Person> personList = new();

            if (count <= 0)
            {
               return personList;
            }
            else
            {
                var id = 1;
                var name = "Oðuz Alp ARSLAN ";
                var age = 24;
                var height = 1.65;
                var isMarried = false;
                var gender = 'M';
                var birthdate = new DateTime(2001, 01, 31);
                var weight = 90;
                var salary = 35000;
                var idNumber = 5465648965;
                short childrenCount = 0;
                byte numberOfPets = 1;
                var isActive = true;
              
                for (int i = 0; i < count; i++)
                {
                    personList.Add(new Person(id,name,age,height,isMarried,gender,birthdate,weight,
                            salary, idNumber, childrenCount, numberOfPets, isActive));
                }

                return personList;

            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
