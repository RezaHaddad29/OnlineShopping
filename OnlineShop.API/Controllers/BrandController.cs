using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.Services;
using OnlineShop.Core.Entities;

namespace OnlineShop.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly BrandService _brandService;

        public BrandController(BrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetAll()
        {
            return Ok(await _brandService.GetBrandsAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Brand brand)
        {
            await _brandService.AddBrandAsync(brand);
            return Ok();
        }

    }
}
