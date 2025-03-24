using OnlineShop.Core.Entities;

namespace OnlineShop.Core.Interfaces.Persistence
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailAsync(string email);
    }
}
