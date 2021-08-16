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
    public class SubProductTreesController : ControllerBase
    {
        ISubProductTreeService _subProductTreeService;

        public SubProductTreesController(ISubProductTreeService subProductTreeService)
        {
            _subProductTreeService = subProductTreeService;
        }

        [HttpGet("getbyid")]
        public SubProductTree GetById(int id)
        {
            return _subProductTreeService.GetById(id);

        }

        [HttpGet("getall")]
        public List<SubProductTree> GetAll()
        {

            return _subProductTreeService.GetAll();


        }

        [HttpPost("add")]
        public void Add(SubProductTree subProductTree)
        {
            _subProductTreeService.Add(subProductTree);

        }

        [HttpPost("update")]
        public void Update(SubProductTree subProductTree)
        {
            _subProductTreeService.Update(subProductTree);

        }

        [HttpPost("delete")]
        public void Delete(SubProductTree subProductTree)
        {
            _subProductTreeService.Delete(subProductTree);

        }
    }
}
