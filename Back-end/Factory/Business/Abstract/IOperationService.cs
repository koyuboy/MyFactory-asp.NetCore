using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOperationService
    {
        List<Operation> GetAll();
        Operation GetById(int id);
        void Add(Operation operation);
        void Update(Operation operation);
        void Delete(Operation operation);
    }
}
