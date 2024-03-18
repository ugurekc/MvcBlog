namespace MvcBlog.Models
{
    public class Customer
    {    
        public string name {  get; set; }
        public string country { get; set; }
        public int income { get; set; }


        
        public Customer(string name, string country, int income)
        {
            this.name = name;
            this.country = country;
            this.income = income;
        }
    }
}
