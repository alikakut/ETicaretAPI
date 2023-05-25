using ETicaretAPI.Application.Repository.Customers;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public CustomerController(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customerReadRepository.GetAll());
        }

        [HttpPost]
        public IActionResult Add([FromBody]Customer customer)
        {
            return Ok(_customerWriteRepository.Add(customer));
        }
        [HttpPut]
        public IActionResult Update([FromBody]Customer customer)
        {
            return Ok(_customerWriteRepository.Update(customer));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Customer customer)
        {
            return Ok(_customerWriteRepository.Remove(customer,id));
        }
    }
}
