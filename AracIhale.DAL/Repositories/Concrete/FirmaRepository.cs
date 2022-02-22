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
    public class FirmaRepository : Repository<Firma>, IFirmaRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public FirmaRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<FirmaVM> GetFirmaVMler()
        {
            FirmaRepository firmaRepository = new FirmaRepository(ThisContext);

            List<Firma> firmalar = firmaRepository.GetAll();

            List<FirmaVM> firmaVMler = new FirmaMapping().ListFirmaToListFirmaVM(firmalar);

            return firmaVMler;
        }

        public List<FirmaVM> GetFirmaAd()
        {
            List<FirmaVM> firmalar = ThisContext.Firma.Select(x => new FirmaVM()
            {
                Unvan = x.Unvan,
                IsActive = x.IsActive
            }).Where(x => x.IsActive == true).ToList();
            return firmalar;
        }
    }   
}
