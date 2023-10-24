using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvcdbfirst.Models;

namespace mvcdbfirst.Controllers
{
    public class ShowtimeController : Controller
    {
        public readonly CinemaContext db;
        public ShowtimeController(CinemaContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var result = db.Showtimes.Include("Theater").Include("Movie").ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Showtime save)
        {
            db.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = db.Showtimes.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Showtime update)
        {
            db.Update(update);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = db.Showtimes.Find(id);
            db.Showtimes.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
