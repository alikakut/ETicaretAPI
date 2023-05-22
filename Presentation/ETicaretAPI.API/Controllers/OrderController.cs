﻿using ETicaretAPI.Application.Repository.Orders;
using ETicaretAPI.Application.ViewModels.Products;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
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

    }
}
