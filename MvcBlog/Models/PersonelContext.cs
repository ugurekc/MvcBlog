using Microsoft.EntityFrameworkCore;

namespace MvcBlog.Models
{
    public class PersonelContext : DbContext
    {
        public PersonelContext(DbContextOptions<PersonelContext> options)
         : base(options)
        {

        }
        public DbSet<PersonDbModel> Person { get; set; }
    }
}
