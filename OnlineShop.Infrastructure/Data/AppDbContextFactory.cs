using Microsoft.EntityFrameworkCore.Design;

namespace OnlineShop.Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("YourConnectionString");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
