using OnlineShop.Core.Interfaces.Persistence;

namespace OnlineShop.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IUserRepository UserRepository { get; }
        Task<int> CompleteAsync();
    }
}
