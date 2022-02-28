using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class PaketRepository : Repository<Paket>, IPaketRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public PaketRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<PaketVM> TumPaketler()
        {
            return new PaketMapping().ListPaketToPaketVM(GetAll());
        }
    }
}
