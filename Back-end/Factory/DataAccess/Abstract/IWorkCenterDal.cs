﻿
using DataAccess.EntityFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IWorkCenterDal : IEntityRepository<WorkCenter>
    {
    }
}
