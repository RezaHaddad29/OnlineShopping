using OnlineShop.Core.Interfaces.Persistence;
using OnlineShop.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShop.Core.Entities;

namespace OnlineShop.Application.Services
{
    public class BrandService
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IUnitOfWork _unitOfWork;

        public BrandService(IBrandRepository brandRepository, IUnitOfWork unitOfWork)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Brand>> GetBrandsAsync()
        {
            return await _brandRepository.GetAllAsync();
        }

        public async Task AddBrandAsync(Brand brand)
        {
            await _brandRepository.AddAsync(brand);
            await _unitOfWork.CompleteAsync();
        }
    }
}
