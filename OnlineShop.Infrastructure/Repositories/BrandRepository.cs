using OnlineShop.Core.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly AppDbContext _context;

        public BrandRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Brand entity)
        {
            await _context.Brands.AddAsync(entity);
        }

        public void Delete(Brand entity)
        {
            _context.Brands.Remove(entity);
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
        {
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            return await _context.Brands.FirstAsync(b => b.ID == id);
        }

        public void Update(Brand entity)
        {
            _context.Brands.Update(entity);
        }
    }
}
