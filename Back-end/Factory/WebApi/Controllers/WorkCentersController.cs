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
    public class WorkCentersController : ControllerBase
    {
        IWorkCenterService _workCenterService;

        public WorkCentersController(IWorkCenterService workCenterService)
        {
            _workCenterService = workCenterService;
        }

        [HttpGet("getbyid")]
        public WorkCenter GetById(int id)
        {
            return _workCenterService.GetById(id);

        }

        [HttpGet("getall")]
        public List<WorkCenter> GetAll()
        {

            return _workCenterService.GetAll();

        }

        [HttpPost("add")]
        public void Add(WorkCenter workCenter)
        {
            _workCenterService.Add(workCenter);

        }

        [HttpPost("update")]
        public void Update(WorkCenter workCenter)
        {
            _workCenterService.Update(workCenter);

        }

        [HttpPost("delete")]
        public void Delete(WorkCenter workCenter)
        {
            _workCenterService.Delete(workCenter);

        }
    }
}
