using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWorkCenterOperationService
    {
        List<WorkCenterOperation> GetAll();
        WorkCenterOperation GetById(int id);
        void Add(WorkCenterOperation workCenterOperation);
        void Update(WorkCenterOperation workCenterOperation);
        void Delete(WorkCenterOperation workCenterOperation);
    }
}
