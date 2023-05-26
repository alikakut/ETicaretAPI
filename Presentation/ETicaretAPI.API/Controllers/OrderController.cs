using ETicaretAPI.Application.Repository.Orders;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;

        public OrderController(IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderReadRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Add([FromBody] Order order)
        {
            return Ok(_orderWriteRepository.Add(order));
        }
        [HttpPut]
        public IActionResult Update([FromBody] Order order)
        {
            return Ok(_orderWriteRepository.Update(order));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Order order)
        {
            return Ok(_orderWriteRepository.Remove(order,id));
        }
    }
}
