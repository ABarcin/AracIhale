using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.CORE.Login;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class CalisanRepository : Repository<Calisan>, ICalisanRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }

        public CalisanRepository(AracIhaleEntities context) : base(context)
        {

        }

        public bool OturumAc(string kullaniciAdi, string sifre)
        {
            bool dogruMu = false;
            Calisan calisan = this.GetAll().Where(x=>x.KullaniciAd.TrimEnd()==kullaniciAdi&&x.Sifre==sifre).SingleOrDefault();

            if (calisan != null) 
            { 
                dogruMu = true; 
            }
            return dogruMu;
        }
        CalisanMapping mapping = new CalisanMapping();
        public List<CalisanVM> TumCalisanlar()
        {
            List<CalisanVM> calisanlar= ThisContext.Calisan.Include("Rol").Select(x => new CalisanVM()
            {
                Ad = x.Ad,
                Soyad = x.Soyad,
                RolAd = x.Rol.Ad,
                KullaniciAd=x.KullaniciAd,
                Sifre=x.Sifre,
                RolID=x.RolID,
                IsActive=x.IsActive,
                CalisanID=x.CalisanID,
                AktiflikDurumu=x.AktiflikDurumu,
            }).Where(x=>x.IsActive==true).ToList();
            return calisanlar;
        }
        public List<CalisanVM> CalisanListesiGetir()
        {
            List<CalisanVM> calisanlistesi = new List<CalisanVM>();

            CalisanRepository calisanRepository = new CalisanRepository(ThisContext);

            CalisanMapping calisanMapping = new CalisanMapping();

            return calisanMapping.ListCalisanToListCalisanVM(calisanRepository.GetAll());
        }
        public void Guncelle(CalisanVM calisan)
        {
            Calisan guncellenecekCalisan = this.GetByID(calisan.CalisanID);
            guncellenecekCalisan.AktiflikDurumu = calisan.AktiflikDurumu;
            guncellenecekCalisan.Ad = calisan.Ad;
            guncellenecekCalisan.Soyad = calisan.Soyad;
            guncellenecekCalisan.Sifre = calisan.Sifre;
            guncellenecekCalisan.KullaniciAd = calisan.KullaniciAd;
            guncellenecekCalisan.RolID = calisan.RolID;
            guncellenecekCalisan.ModifiedBy = Login.GirisYapmisCalisan.KullaniciAd;
            guncellenecekCalisan.ModifiedDate = DateTime.Now;
            this.Update(guncellenecekCalisan);
        }
        public void Ekle(CalisanVM calisan)
        {
            Calisan eklenecekCalisan = new Calisan();
            eklenecekCalisan.AktiflikDurumu = calisan.AktiflikDurumu;
            eklenecekCalisan.Ad = calisan.Ad;
            eklenecekCalisan.Soyad = calisan.Soyad;
            eklenecekCalisan.Sifre = calisan.Sifre;
            eklenecekCalisan.KullaniciAd = calisan.KullaniciAd;
            eklenecekCalisan.RolID = calisan.RolID;
            eklenecekCalisan.CreatedBy = calisan.KullaniciAd;
            eklenecekCalisan.ModifiedBy = calisan.KullaniciAd;
            this.Add(eklenecekCalisan);
        }

        public CalisanVM KullaniciGetir(object id)
        {
            CalisanRepository calisanRepository = new CalisanRepository(ThisContext);
            Calisan c = calisanRepository.GetByID(id);
            return c==null?null: mapping.CalisanToCalisanVM(c);
        }
        public void Sil(object id)
        {
            Calisan silinecekCalisan = this.GetByID(id);
            this.SoftRemove(silinecekCalisan);
        }

        public CalisanVM KullaniciGetir(string kullaniciAdi)
        {
            CalisanRepository calisanRepository = new CalisanRepository(ThisContext);
            Calisan c = calisanRepository.GetAll(x=>x.KullaniciAd==kullaniciAdi).FirstOrDefault();
            return c==null? null: mapping.CalisanToCalisanVM(c);
        }

        public int CalisanIdGetir()
        {
            return this.GetAll().OrderByDescending(x => x.CalisanID).First().CalisanID;
        }
    }
}
