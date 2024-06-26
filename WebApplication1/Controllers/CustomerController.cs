﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Register(AddCustomerForm form)
        {
            if (ModelState.IsValid)
            {
                var name = form.name;
                var email = form.email;
                var phone = form.phone;
                var country = form.country;
                CustomerData.Customers.Add(new Customer { name = name, email = email, id = 100, phone = phone, country = country });
                return RedirectToAction("Index");
            }
            return View();
            
        }
        
    }
}
