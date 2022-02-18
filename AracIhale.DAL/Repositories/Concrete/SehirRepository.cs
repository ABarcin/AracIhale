﻿using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class SehirRepository : Repository<Sehir>, ISehirRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public SehirRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
