using Microsoft.AspNetCore.Mvc;
using mvcdbfirst.Models;

namespace mvcdbfirst.Controllers
{
    public class TicketSaleController : Controller
    {
        public readonly CinemaContext db;
        public TicketSaleController(CinemaContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var result = db.TicketSales.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TicketSale save)
        {
            db.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = db.TicketSales.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(TicketSale update)
        {
            db.Update(update);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = db.TicketSales.Find(id);
            db.TicketSales.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
