using ForumApp.Core.Contracts;
using ForumApp.Core.Models;
using ForumApp.Infrastructer.Data;
using ForumApp.Infrastructer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Core.Services
{
    public class PostService : IPostService
    {
        private readonly FormDbContext context;
        public PostService(FormDbContext _context)
        {
            context = _context;
        }

        public async Task AddAsync(PostModel model)
        {
            var newPost = new Post
            {
                Title = model.Title,
                Content = model.Content,
            };
            await context.Posts.AddAsync(newPost);
            await context.SaveChangesAsync();
           
        }

        public async Task<IEnumerable<PostModel>> AllAsync()
        {
            var entityes = await this.context
                .Posts
                .Select(p=> new PostModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content=p.Content
                }
                ).AsNoTracking()
                .ToListAsync();
            return entityes;
        }

        public async Task DeleteAsync(PostModel postModel)
        {
           var entity= await context.Posts.FindAsync(postModel.Id);
            if (entity == null)
            {
                throw new ApplicationException("The entity is not valid!!!");
            }
            context.Posts.Remove(entity);
            await context.SaveChangesAsync();

        }

        public async Task EditAsync(PostModel model)
        {
            var entity = await context.Posts.FindAsync(model.Id);
            if(entity == null)
            {
                throw new Exception();
            }
            entity.Title = model.Title;
            entity.Content = model.Content;
            await context.SaveChangesAsync();
        }

        public async Task<PostModel?> GetByIdAsync(int id)
        {
           return await context.Posts.Where(p=>p.Id==id)
                .Select(p =>new PostModel
                {
                    Id=p.Id,
                    Title = p.Title,
                    Content=p.Content
                }).FirstOrDefaultAsync();
                

        }

        
    }
}
