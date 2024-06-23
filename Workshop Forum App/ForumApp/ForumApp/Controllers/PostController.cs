using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        public PostController(IPostService _postService)
        {
            postService = _postService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var models = await postService.AllAsync();
            return View(models);
        }
        [HttpGet]
        public IActionResult Add()
        {
            var post = new PostModel();
            return View(post);
        }
        [HttpPost]
        public  async Task<IActionResult> Add(PostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
              
            }
             await postService.AddAsync(model);
            return RedirectToAction(nameof(Index));   
            
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            PostModel? editPost = await postService.GetByIdAsync(id);
            if(editPost == null)
            {
                ModelState.AddModelError("", "This post is invalid");
            }
            return View(editPost);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(PostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await postService.EditAsync(model);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            PostModel? post = await postService.GetByIdAsync(id);
            if(post == null)
            {
                throw new ApplicationException("The post doesn t exsist");

            }
            await postService.DeleteAsync(post);

            return RedirectToAction(nameof(Index));
             

        }
      
        
      
       
    }
}
