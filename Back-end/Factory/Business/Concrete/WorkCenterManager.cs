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
    public class WorkCenterManager : IWorkCenterService
    {
        private IWorkCenterDal _workCenterDal;

        public WorkCenterManager(IWorkCenterDal workCenterDal)
        {
            _workCenterDal = workCenterDal;
        }

        public void Add(WorkCenter workCenter)
        {
            _workCenterDal.Add(workCenter);
        }

        public void Delete(WorkCenter workCenter)
        {
            _workCenterDal.Delete(workCenter);
        }

        public List<WorkCenter> GetAll()
        {
            return _workCenterDal.GetAll();
        }

        public WorkCenter GetById(int id)
        {
            if (id > 0)
            {
                return _workCenterDal.Get(w => w.WorkCenterId== id);
            }
            throw new Exception("id can not be less than 1");
        }

        public void Update(WorkCenter workCenter)
        {
            _workCenterDal.Update(workCenter);
        }
    }
}
