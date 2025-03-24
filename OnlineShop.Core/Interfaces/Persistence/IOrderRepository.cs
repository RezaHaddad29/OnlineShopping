using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Interfaces.Persistence
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
    }
}
