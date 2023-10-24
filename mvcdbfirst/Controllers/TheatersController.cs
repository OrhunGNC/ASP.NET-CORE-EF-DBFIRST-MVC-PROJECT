using Microsoft.AspNetCore.Mvc;
using mvcdbfirst.Models;

namespace mvcdbfirst.Controllers
{
    public class TheatersController : Controller
    {
        public readonly CinemaContext db;
        public TheatersController(CinemaContext db)
        {
            this.db = db;
        }                                       
        public IActionResult Index()
        {
            var result = db.Theaters.ToList();
            return View(result);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Theater save)
        {
            db.Add(save);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var result = db.Theaters.Find(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Theater update)
        {
            db.Update(update);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var delete = db.Theaters.Find(id);
            db.Theaters.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
