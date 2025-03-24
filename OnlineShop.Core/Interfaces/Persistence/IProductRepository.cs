using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Interfaces.Persistence
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Product>> GetByBrandIdAsync(int brandId);
    }
}
