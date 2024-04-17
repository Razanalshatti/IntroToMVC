namespace WebApplication1.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
    }

    public static class CustomerData
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new Customer { id = 1, name = "Razan Alshatti" , email = "razan@gmail.com" , phone = "99887766" , country = "kuwait" },
            new Customer { id = 2, name = "Nada Alshaibani" , email = "nada@gmail.com" , phone = "66778899" , country = "kuwait" }
        };
    }
}
