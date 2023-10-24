using Microsoft.AspNetCore.Mvc;

namespace mvcdbfirst.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
