using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Controllers
{
    public class AnimalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
