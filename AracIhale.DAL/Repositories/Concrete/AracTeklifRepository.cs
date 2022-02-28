using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class AracTeklifRepository : Repository<AracTeklif>, IAracTeklifRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracTeklifRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AracTeklifEkle(AracTeklifVM aracTeklifVM)
        {
            AracTeklif teklif = new AracTeklifMapping().AracTeklifVMToAracTeklif(aracTeklifVM);
            teklif.CreatedDate = DateTime.Now;
            teklif.IsActive = true;
            this.Add(teklif);
        }
    }
}
