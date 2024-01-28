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

            _db.Customers.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Customer customerFromDb = _db.Customers.Find(id);

            if (customerFromDb == null)
            {
                return NotFound();
            }

            return View(customerFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Customer obj)
        {

            _db.Customers.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Customer customerFromDb = _db.Customers.Find(id);

            if (customerFromDb == null)
            {
                return NotFound();
            }

            return View(customerFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Customer obj = _db.Customers.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Customers.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
