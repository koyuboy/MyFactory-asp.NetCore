using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubProductTreeService
    {
        List<SubProductTree> GetAll();
        SubProductTree GetById(int id);
        void Add(SubProductTree subProductTree);
        void Update(SubProductTree subProductTree);
        void Delete(SubProductTree subProductTree);
    }
}
