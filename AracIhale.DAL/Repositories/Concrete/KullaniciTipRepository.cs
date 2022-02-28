using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class KullaniciTipRepository : Repository<KullaniciTip>, IKullaniciTipRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public KullaniciTipRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<KullaniciTipVM> GetKullaniciTipVM()
        {
            KullaniciTipRepository kullaniciTipRepository = new KullaniciTipRepository(ThisContext);

            List<KullaniciTip> kullaniciTipleri = kullaniciTipRepository.GetAll();

            List<KullaniciTipVM> kullaniciTipVMler = new KullaniciTipMapping().ListKullaniciTipToListKullaniciTipVM(kullaniciTipleri);

            return kullaniciTipVMler;
        }
        public List<KullaniciTipVM> KullaniciTipListele()
        {
            var kullaniciTipleri = ThisContext.KullaniciTip.Select(x => new KullaniciTipVM
            {
                Tip = x.Tip,
                KullaniciTipID = x.KullaniciTipID,
                IsActive = x.IsActive,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate,
                ModifiedBy = x.ModifiedBy,
                ModifiedDate = x.ModifiedDate
            }).ToList();

            return kullaniciTipleri;
        }
    }
}
