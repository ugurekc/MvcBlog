using MvcBlog.Models;

namespace MvcBlog.ViewModels
{
    public class PersonDbViewModel
    {
        public List<PersonDbModel> Persons { get; set; }
        public PersonDbModel OnePerson { get; set; }
    }
}
