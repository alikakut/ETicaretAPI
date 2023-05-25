using System.Net;
using ETicaretAPI.Application.Repository.Orders;
using ETicaretAPI.Application.Repository.Products;
using ETicaretAPI.Application.ViewModels.Products;
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
        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(_productReadRepository.GetAll());
        }
        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            return Ok(_productWriteRepository.Add(product));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Product product)
        {
            return Ok(_productWriteRepository.Update(product));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Product product)
        {
            return Ok(_productWriteRepository.Remove(product,id));
        }
    }
}
