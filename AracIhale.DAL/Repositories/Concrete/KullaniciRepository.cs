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
            Kullanici kullanici = new KullaniciMapping().KullaniciVMToKullanici(kullaniciVM);

            kullanici.CreatedDate = DateTime.Now;
            kullanici.IsActive = true;

            this.Add(kullanici);
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
        public KullaniciVM AracKullanicisiniGetir(int aracID)
        {
            return new KullaniciMapping().KullaniciToKullaniciVM(ThisContext.Arac.Where(x => x.AracID == aracID).Select(y => y.Kullanici).FirstOrDefault());
        }

        public KullaniciVM KullaniciGetir(string kullaniciAdi)
        {
            Kullanici kullanici =GetAll(x => x.KullaniciAd == kullaniciAdi).FirstOrDefault();
            return kullanici == null ? null :new KullaniciMapping().KullaniciToKullaniciVM(kullanici);
        }

        public KullaniciVM KullaniciGetir(object id)
        {
            return new KullaniciMapping().KullaniciToKullaniciVM(GetByID(id));
        }

        public bool OturumAc(string kullaniciAdi, string sifre)
        {
            bool dogruMu = false;
            Kullanici calisan = GetAll().Where(x => x.KullaniciAd.TrimEnd() == kullaniciAdi && x.Sifre == sifre).SingleOrDefault();
            if (calisan != null)
            {
                dogruMu = true;
            }
            return dogruMu;
        }
    }
}
