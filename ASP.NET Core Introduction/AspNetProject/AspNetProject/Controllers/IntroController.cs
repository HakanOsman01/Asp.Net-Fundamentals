using AspNetProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetProject.Controllers
{
    public class IntroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetStudent()
        {
            ViewBag.Title = "GetStudent";
            var student = new Student()
            {
                Name = "Hakan",
                Id = 1,
                Email = "haki2001@abv.bg"
            };
            return View("DataStudent",student);
        }
        public IActionResult EditStudent(Student model)
        {
            if (!ModelState.IsValid)
            {
                return View("DataStudent",model);
            }
            ViewBag.Title = "EditStudent";
            return RedirectToAction(nameof(Index));

        }
    }
}
