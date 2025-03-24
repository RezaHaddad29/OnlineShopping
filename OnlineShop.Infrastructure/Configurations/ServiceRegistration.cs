using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Core.Interfaces.Persistence;
using OnlineShop.Infrastructure.Repositories;

namespace OnlineShop.Infrastructure.Configurations
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
