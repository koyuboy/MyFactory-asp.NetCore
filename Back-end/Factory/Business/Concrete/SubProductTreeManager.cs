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
    public class SubProductTreeManager : ISubProductTreeService
    {
        private ISubProductTreeDal _subProductTreeDal;

        public SubProductTreeManager(ISubProductTreeDal subProductTreeDal)
        {
            _subProductTreeDal = subProductTreeDal;
        }

        public void Add(SubProductTree subProductTree)
        {
            _subProductTreeDal.Add(subProductTree);
        }

        public void Delete(SubProductTree subProductTree)
        {
            _subProductTreeDal.Delete(subProductTree);
        }

        public List<SubProductTree> GetAll()
        {
            return _subProductTreeDal.GetAll();
        }

        public SubProductTree GetById(int id)
        {
            if (id > 0)
            {
                return _subProductTreeDal.Get(s => s.SubProductId == id);
            }
            throw new Exception("id can not be less than 1");
        }

        public void Update(SubProductTree subProductTree)
        {
            _subProductTreeDal.Update(subProductTree);
        }
    }
}
