using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
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
            List<RolVM> roller=ThisContext.Rol.Select(x => new RolVM()
            {
                Ad=x.Ad,
                RolID=x.RolID,
                IsActive=x.IsActive
            }).Where(x => x.IsActive == true).ToList();
            return roller;
        }
        //burak
        public string RolAdiGetir(int rolID)
        {
            Rol rol = ThisContext.Rol.Where(x => x.RolID == rolID).FirstOrDefault();

            return rol.Ad;
        }
    }
}
