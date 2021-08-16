using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkCenterService
    {
        List<WorkCenter> GetAll();
        WorkCenter GetById(int id);
        void Add(WorkCenter workCenter);
        void Update(WorkCenter workCenter);
        void Delete(WorkCenter workCenter);
    }
}
