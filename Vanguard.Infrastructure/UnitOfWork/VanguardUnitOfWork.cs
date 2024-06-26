﻿
using Vanguard.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vanguard.Core.Data.UnitOfWork;

namespace Vanguard.Infrastructre.UnitOfWork
{
    public class VanguardUnitOfWork : UnitOfWork<VanguardDbContext>, IVanguardUnitOfWork
    {
        public VanguardUnitOfWork(VanguardDbContext context) : base(context)
        {
        }
    }
}
