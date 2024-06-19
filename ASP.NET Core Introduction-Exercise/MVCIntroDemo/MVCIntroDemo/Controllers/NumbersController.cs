using Microsoft.AspNetCore.Mvc;

namespace MVCIntroDemo.Controllers
{
    public class NumbersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
