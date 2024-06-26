using Eventmi.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Eventmi.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService eventService;
        public EventController(IEventService _eventService)
        {
            this.eventService = _eventService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var events= await eventService.GetAllEventsAsync();
            return View(events);
        }
    }
}
