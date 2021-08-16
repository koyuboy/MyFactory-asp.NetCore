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
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getbyid")]
        public User GetById(int id)
        {
            return _userService.GetById(id);

        }

        [HttpGet("getall")]
        public List<User> GetAll()
        {

            return _userService.GetAll();


        }

        [HttpPost("add")]
        public void Add(User user)
        {
            _userService.Add(user);

        }

        [HttpPost("update")]
        public void Update(User user)
        {
            _userService.Update(user);

        }

        [HttpPost("delete")]
        public void Delete(User user)
        {
            _userService.Delete(user);

        }

        [HttpPost("login")]
        public bool Login(string name, string password)
        {
            return _userService.Login(name,password);

        }
    }
}
