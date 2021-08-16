using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("getbyid")]
        public Order GetById(int id)
        {
            return _orderService.GetById(id);

        }

        [HttpGet("getall")]
        public List<Order> GetAll()
        {
            return _orderService.GetAll();
        }

        [HttpPost("add")]
        public void Add()
        {
            _orderService.Add();

        }


        [HttpPost("update")]
        public void Update(Order order)
        {
            _orderService.Update(order);

        }

        [HttpPost("delete")]
        public void Delete(Order order)
        {
            _orderService.Delete(order);

        }

        [HttpGet("orderstatus")]
        public List<Order> CheckOrderStatus()
        {
            return _orderService.CheckOrderStatus();
        }

        [HttpGet("allordersstatus")]
        public List<Order> CheckAllOrdersStatus()
        {
            return _orderService.CheckAllOrdersStatus();
        }
    }
}
