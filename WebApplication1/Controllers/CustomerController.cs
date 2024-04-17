using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View(CustomerData.Customers);
        }
        public IActionResult Details(int id)
        {
            var customer = CustomerData.Customers.First(x => x.id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(IFormCollection form)
        {
            var name = form["name"];
            var email = form["email"];
            CustomerData.Customers.Add(new Customer { name = name, email = email, id = 10 });
            return RedirectToAction("Index","Customer");
            return View();
        }
        
    }
}
