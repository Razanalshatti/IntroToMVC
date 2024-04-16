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

    }
}
