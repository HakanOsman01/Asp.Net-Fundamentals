using ForumApp.Core.Models;
using ForumApp.Infrastructer.Data.Models;

namespace ForumApp.Core.Contracts
{
    public interface IPostService
    {
        Task<IEnumerable<PostModel>> AllAsync();
        Task AddAsync(PostModel model);
        Task<PostModel?> GetByIdAsync(int id);
        Task EditAsync(PostModel model);
        Task DeleteAsync(PostModel postModel);
    }
}
