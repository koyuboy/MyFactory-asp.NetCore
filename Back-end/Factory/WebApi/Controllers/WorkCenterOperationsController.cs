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
    public class WorkCenterOperationsController : ControllerBase
    {
        IWorkCenterOperationService _workCenterOperationService;

        public WorkCenterOperationsController(IWorkCenterOperationService workCenterOperationService)
        {
            _workCenterOperationService = workCenterOperationService;
        }

        [HttpGet("getbyid")]
        public WorkCenterOperation GetById(int id)
        {
            return _workCenterOperationService.GetById(id);

        }

        [HttpGet("getall")]
        public List<WorkCenterOperation> GetAll()
        {

            return _workCenterOperationService.GetAll();


        }

        [HttpPost("add")]
        public void Add(WorkCenterOperation workCenterOperation)
        {
            _workCenterOperationService.Add(workCenterOperation);

        }

        [HttpPost("update")]
        public void Update(WorkCenterOperation workCenterOperation)
        {
            _workCenterOperationService.Update(workCenterOperation);

        }

        [HttpPost("delete")]
        public void Delete(WorkCenterOperation workCenterOperation)
        {
            _workCenterOperationService.Delete(workCenterOperation);

        }
    }
}
