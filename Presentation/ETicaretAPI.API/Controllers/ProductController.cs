using ETicaretAPI.Application.Repository.Orders;
using ETicaretAPI.Application.Repository.Products;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderWriteRepository orderWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
        }

        //[HttpGet]
        //public async Task Get()
        //{
        //    await _productWriteRepository.AddAsync(new() { Name = "product", Price = 200, Stock = 14, CreatedDate = DateTime.UtcNow,UpdateBy = DateTime.UtcNow.ToString() });
        //    await _productWriteRepository.SaveAsync();

        //}
        [HttpGet]
        public async Task Get()
        {
            await _orderWriteRepository.AddAsync(new() { Description = "fnjdnvdjv", Address = "istanbul", UpdateBy=DateTime.UtcNow.ToString(), Customer = new Domain.Entities.Customer
            {
                Id = 3,
                Name ="bilgisayar"
            }
            });
            await _orderWriteRepository.SaveAsync();

        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Product product)
        {
            await _productWriteRepository.AddAsync(product);
            int affectedRows = await _productWriteRepository.SaveAsync();

            if (affectedRows > 0)
            {
                return Ok(product);
            }
            else
            {
                return BadRequest();
            }
        } 
    }
}
