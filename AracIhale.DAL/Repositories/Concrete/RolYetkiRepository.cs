﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class RolYetkiRepository : Repository<RolYetki>, IRolYetkiRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public RolYetkiRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
