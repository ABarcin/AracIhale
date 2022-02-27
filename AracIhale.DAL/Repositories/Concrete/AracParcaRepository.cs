﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class AracParcaRepository : Repository<AracParca>, IAracParcaRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracParcaRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<AracParcaVM> AracParcaListesiGetir()
        {
            return new AracParcaMapping().ListAracParcaToListAracParcaVM(GetAll());
        }
    }
}
