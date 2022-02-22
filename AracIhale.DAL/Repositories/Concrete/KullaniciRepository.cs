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
    public class KullaniciRepository : Repository<Kullanici>, IKullaniciRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public KullaniciRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void BireyselKullaniciEkle(KullaniciVM kullaniciVM)
        {
            KullaniciRepository kullaniciRepository = new KullaniciRepository(ThisContext);

            Kullanici kullanici = new KullaniciMapping().KullaniciVMToKullanici(kullaniciVM);

            kullanici.CreatedDate = DateTime.Now;
            kullanici.IsActive = true;

            kullaniciRepository.Add(kullanici);
        }

        public List<KullaniciTipVM> GetKullaniciTip()
        {
            List<KullaniciTipVM> kullaniciTipleri = ThisContext.KullaniciTip.Select(x => new KullaniciTipVM()
            {
                Tip = x.Tip,
                IsActive = x.IsActive
            }).Where(x => x.IsActive == true).ToList();
            return kullaniciTipleri;
        }
    }
}
