using Microsoft.AspNetCore.Mvc;
using mvcdbfirst.Models;

namespace mvcdbfirst.Controllers
{
    public class MovieController : Controller
    {
        public readonly CinemaContext db;
        public MovieController(CinemaContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var result = db.Movies.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie save)
        {
            db.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = db.Movies.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Movie update)
        {
            db.Update(update);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = db.Movies.Find(id);
            db.Movies.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
