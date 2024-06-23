using Microsoft.AspNetCore.Mvc;
using TextSplitterApp.Models;

namespace TextSplitterApp.Controllers
{
    public class TextSplitController : Controller
    {
        [HttpGet]
        public IActionResult Index(TextSplitViewModel model)
        {
            return View(model);
        }
        [HttpPost]
        public IActionResult Split(TextSplitViewModel model)
        {
            string[] splitText = model.Text
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .ToArray();
            model.SplitText=string.Join(Environment.NewLine, splitText);
            return RedirectToAction("Index",model);


        }
    }
}
