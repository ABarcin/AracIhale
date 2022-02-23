using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using SayfaIhale.MODEL.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class SayfaRepository : Repository<Sayfa>, ISayfaRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public SayfaRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<SayfaVM> TumSayfalar()
        {
            return new SayfaMapping().ListSayfaToListSayfaVM(this.GetAll().ToList());
        }
    }
}
