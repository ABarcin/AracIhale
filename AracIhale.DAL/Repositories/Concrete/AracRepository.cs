using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class AracRepository : Repository<Arac>, IAracRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<Arac> GetAraclarWithRelationship()
        {
            List<Arac> araclar = ThisContext.Arac.Include("ArabaModel").Include("Kullanici").Include("Marka").ToList();

            return araclar;
        }

        public List<AracCDListVM> GetAracByIhaleID(int id)
        {
            IhaleAracRepository ihaleAracRepository = new IhaleAracRepository(ThisContext);

            AracStatuRepository aracStatuRepository = new AracStatuRepository(ThisContext);

            List<IhaleArac> ihaleAraclar = ihaleAracRepository.GetAll(x => x.IhaleID == id);

            List<Arac> araclar = new List<Arac>();

            List<AracCDListVM> aracVMler = new List<AracCDListVM>();

            foreach (var item in ihaleAraclar)
            {
                araclar.Add(this.GetAracWithRelationshipByID(item.AracID));
            }

            foreach (var item in araclar)
            {
                AracCDListVM aracListVM = new AracCDListVM();
                aracListVM.AracID = item.AracID;
                aracListVM.AracID = item.AracID;
                aracListVM.MarkaID = item.MarkaID;
                aracListVM.ModelID = item.ModelID;
                aracListVM.Km = item.Km;
                aracListVM.Yil = item.Yil;
                aracListVM.ArabaModel = item.ArabaModel;
                aracListVM.Kullanici = item.Kullanici;
                aracListVM.KullaniciTipAdi = ThisContext.KullaniciTip.Where(x => x.KullaniciTipID == item.Kullanici.KullaniciTipID).FirstOrDefault().Tip;
                aracListVM.Marka = item.Marka;
                aracListVM.Statu = ThisContext.AracStatu.Include("Statu").ToList().Where(y => y.AracID == item.AracID).OrderByDescending(x => x.Tarih).FirstOrDefault().Statu;

                aracVMler.Add(aracListVM);
            }

            return aracVMler;
        }

        public Arac GetAracWithRelationshipByID(int id)
        {
            return ThisContext.Arac.Include("ArabaModel").Include("Kullanici").Include("Marka").Where(x => x.AracID == id).FirstOrDefault();
        }

        public List<AracListVM> AracListele(string marka = null, string model = null, string kTip = null, string statu = null)
        {
            // Aktif olan tüm araçları alıyoruz.
            var aracLists = TumAraclariListele();

            // Marka null değilse markaya göre filtreleme yapılacak.
            if (marka != null)
            {
                aracLists = aracLists.Where(x => x.MarkaAd == marka).ToList();
            }
            // Model null değilse modele göre filtreleme yapılacak.
            if (model != null)
            {
                aracLists = aracLists.Where(x => x.ModelAd == model).ToList();
            }
            // Kullanıcı Tipi null değilse kullanıcı tipine göre filtreleme yapılacak.
            if (kTip != null)
            {
                aracLists = aracLists.Where(x => x.KullaniciTip == kTip).ToList();
            }
            // Statu null değilse statüye gore filtreleme yapılacak.
            if (statu != null)
            {
                aracLists = aracLists.Where(x => x.StatuAd == statu).ToList();
            }
            return aracLists;
        }

        public List<AracListVM> TumAraclariListele()
        {
            var aracList = ThisContext.Arac.Include("ArabaModel").Include("Kullanici").Include("Marka").Include("Statu").Include("AracStatu")
                .Where(x=>x.IsActive == true)
                .Select(x => new AracListVM
                {
                    MarkaAd = x.Marka.Ad,
                    ModelAd = x.ArabaModel.Ad,
                    KullaniciTip = x.Kullanici.KullaniciTip.Tip,
                    StatuID = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().StatuID,
                    StatuAd = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().Statu.StatuAd,
                    KullaniciID = x.KullaniciID,
                    KullaniciAd = x.Kullanici.KullaniciAd
                }).ToList();

            return aracList;
        }

        public List<AracListVM> AracVMListele()
        {
            var aracList = ThisContext.Arac.Include("ArabaModel").Include("Kullanici").Include("Marka").ToList();

            return new AracListMapping().ListAracToListAracVM(aracList);
        }
    }
}
