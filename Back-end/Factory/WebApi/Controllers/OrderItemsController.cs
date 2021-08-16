using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        IOrderItemService _orderItemService;

        public OrderItemsController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        [HttpGet("getbyid")]
        public OrderItem GetById(int id)
        {
            return _orderItemService.GetById(id);

        }

        [HttpGet("getall")]
        public List<OrderItem> GetAll()
        {

            return _orderItemService.GetAll();


        }

        [HttpPost("add")]
        public void Add(Product product)
        {
            _orderItemService.Add(product);

        }

        [HttpPost("update")]
        public void Update(OrderItem orderItem)
        {
            _orderItemService.Update(orderItem);

        }

        [HttpPost("delete")]
        public void Delete(OrderItem orderItem)
        {
            _orderItemService.Delete(orderItem);

        }
    }
}
