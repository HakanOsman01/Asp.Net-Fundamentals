using DemoEntityFramework.Models;

namespace DemoEntityFramework.Contracts
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductViewModel>> GetAllAsync();
        Task<ProductViewModel> GetByIdAsync(int id);
        Task AddProductAsync(ProductViewModel model);
        Task UpdateProductAsync(ProductViewModel model);
        Task DeleteProductAsync(int id);


    }
}
