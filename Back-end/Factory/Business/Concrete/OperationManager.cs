
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
    public class OperationManager : IOperationService
    {
        private IOperationDal _operationDal;

        public OperationManager(IOperationDal operationDal)
        {
            _operationDal = operationDal;
        }

        public void Add(Operation operation)
        {
            _operationDal.Add(operation);
        }

        public void Delete(Operation operation)
        {
            _operationDal.Delete(operation);
        }

        public List<Operation> GetAll()
        {
            return _operationDal.GetAll();
        }

        public Operation GetById(int id)
        {
            if (id > 0)
            {
                return _operationDal.Get(o => o.OperationId == id);
            }
            throw new Exception("id can not be less than 1");
        }

        public void Update(Operation operation)
        {
            _operationDal.Update(operation);
        }
    }
}
