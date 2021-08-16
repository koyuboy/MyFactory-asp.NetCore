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
    public class OperationsController : ControllerBase
    {
        IOperationService _operationService;

        public OperationsController(IOperationService operationService)
        {
            _operationService = operationService;
        }

        [HttpGet("getbyid")]
        public Operation GetById(int id)
        {
            return _operationService.GetById(id);

        }

        [HttpGet("getall")]
        public List<Operation> GetAll()
        {

            return _operationService.GetAll();


        }

        [HttpPost("add")]
        public void Add(Operation operation)
        {
            _operationService.Add(operation);

        }

        [HttpPost("update")]
        public void Update(Operation operation)
        {
            _operationService.Update(operation);

        }

        [HttpPost("delete")]
        public void Delete(Operation operation)
        {
            _operationService.Delete(operation);

        }
    }
}
