using OnlineShop.Core.Interfaces;
using OnlineShop.Core.Interfaces.Persistence;

namespace OnlineShop.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IUserRepository UserRepository { get; }

        public UnitOfWork(AppDbContext context,
                          IProductRepository productRepository
                          //IOrderRepository orderRepository,
                          //IUserRepository userRepository
            )
        {
            _context = context;
            ProductRepository = productRepository;
            //OrderRepository = orderRepository;
            //UserRepository = userRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
