using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskBoardApp.Data;
using TaskBoardApp.Models;

namespace TaskBoardApp.Controllers
{
    [Aut]
    public class BoardController : Controller
    {
        private readonly TaskBoardAppDbContext context;
        public BoardController(TaskBoardAppDbContext _context)
        {
            context = _context;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var boards  = await context.Boards.Select(b=>new BoardViewModel
            {
                Id = b.Id,
                Name = b.Name,
                Tasks=b.Tasks.Select(t=>new TaskViewModel()
                {
                    Id = t.Id,
                    CreatedOn = t.CreatedOn,
                    Description= t.Description,
                    Owner=t.Owner.UserName,
                    Title=t.Title,
                })

            })
            .ToListAsync();
            return View(boards);
        }
    }
}
