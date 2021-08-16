using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class WorkCenterOperationManager : IWorkCenterOperationService
    {
        private IWorkCenterOperationDal _workCenterOperationDal;

        public WorkCenterOperationManager(IWorkCenterOperationDal workCenterOperationDal)
        {
            _workCenterOperationDal = workCenterOperationDal;
        }

        public void Add(WorkCenterOperation workCenterOperation)
        {
            _workCenterOperationDal.Add(workCenterOperation);
        }

        public void Delete(WorkCenterOperation workCenterOperation)
        {
            _workCenterOperationDal.Delete(workCenterOperation);
        }

        public List<WorkCenterOperation> GetAll()
        {
            return _workCenterOperationDal.GetAll();
        }

        public WorkCenterOperation GetById(int id)
        {
            if (id > 0)
            {
                return _workCenterOperationDal.Get(w => w.WcOprId== id);
            }
            throw new Exception("id can not be less than 1");
        }

        public void Update(WorkCenterOperation workCenterOperation)
        {
            _workCenterOperationDal.Update(workCenterOperation);
        }
    }
}
