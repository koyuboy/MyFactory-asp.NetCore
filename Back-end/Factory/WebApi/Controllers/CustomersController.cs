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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getbyid")]
        public Customer GetById(int id)
        {
            return _customerService.GetById(id); 
           
        }

        [HttpGet("getall")]
        public List<Customer> GetAll()
        {

            return _customerService.GetAll();
            

        }

        [HttpPost("add")]
        public void Add(Customer customer)
        {
            _customerService.Add(customer);
          
        }

        [HttpPost("update")]
        public void Update(Customer customer)
        {
            _customerService.Update(customer);
            
        }

        [HttpPost("delete")]
        public void Delete(Customer customer)
        {
             _customerService.Delete(customer);
            
        }

        [HttpPost("login")]
        public bool Login(string name, string password)
        {
            return _customerService.Login(name, password);

        }
    }
}
