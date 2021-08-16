using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class WorkCenterOperationDal : EfEntityRepositoryBase<WorkCenterOperation, FactoryDbContext>, IWorkCenterOperationDal
    {
    }
}
