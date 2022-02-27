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
    public class RolRepository : Repository<Rol>, IRolRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public RolRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<RolVM> TumRoller()
        {
            return new RolMapping().ListRolToRolVM(GetAll(x => x.IsActive == true));
        }

        public string RolAdiGetir(int rolID)
        {
            return GetAll(x => x.RolID == rolID).FirstOrDefault().Ad;
        }

        public int RolIDGetir(string rolAd)
        {
            return GetAll(x => x.Ad == rolAd).FirstOrDefault().RolID;
        }
    }
}
