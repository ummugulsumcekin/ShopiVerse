using Microsoft.AspNetCore.Mvc;
using ShopiVerse.Data;
using ShopiVerse.Models;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ShopiVerse.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ProjectDbContext _db;
        public CustomerController(ProjectDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Customer> objCustomerList = _db.Customers.ToList();
            return View(objCustomerList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer obj)
        {
            if (ModelState.IsValid) 
            { 
            _db.Customers.Add(obj);
            _db.SaveChanges();
             return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}
