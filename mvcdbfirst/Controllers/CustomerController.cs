using Microsoft.AspNetCore.Mvc;
using mvcdbfirst.Models;

namespace mvcdbfirst.Controllers
{
    public class CustomerController : Controller
    {
        public readonly CinemaContext db;
        public CustomerController(CinemaContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var result = db.Customers.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer save)
        {
            db.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = db.Customers.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            db.Update(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = db.Customers.Find(id);
            db.Customers.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
