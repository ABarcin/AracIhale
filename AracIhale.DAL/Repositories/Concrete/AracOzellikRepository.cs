using System;
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
    public class AracOzellikRepository : Repository<AracOzellik>, IAracOzellikRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracOzellikRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AracOzellikEkle(List<AracOzellikVM> aracOzellikVMs)
        {
            List<AracOzellik> eklenecekAracOzellikler = new AracOzellikMapping().ListAracOzellikVMToListAracOzellik(aracOzellikVMs);
            this.AddRange(eklenecekAracOzellikler);
        }
    }
}
