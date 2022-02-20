using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
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

            List<IhaleArac> ihaleAraclar = ihaleAracRepository.GetAll();

            List<Arac> araclar = new List<Arac>();

            List<AracCDListVM> aracVMler = new List<AracCDListVM>();

            foreach (var item in ihaleAraclar)
            {
                if (item.AracID == id)
                {
                    araclar.Add(GetAracWithRelationshipByID(item.AracID));
                }
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
                aracListVM.Marka = item.Marka;

                aracVMler.Add(aracListVM);
            }

            return aracVMler;
        }

        public Arac GetAracWithRelationshipByID(int id)
        {
            return ThisContext.Arac.Include("ArabaModel").Include("Kullanici").Include("Marka").Where(x => x.AracID == id).FirstOrDefault();
        }
        public List<AracListVM> AracListele(MarkaVM marka, ArabaModelVM model, KullaniciTipVM kTip, StatuVM statu)
        {
            //var aracList = ThisContext.Arac.Include("ArabaModel").Include("Calisan").Include("Kullanici").Include("Marka").Include("AracStatu")
            //    .Where(y => y.MarkaID == marka.MarkaID && y.ModelID == model.ModelID && y.Kullanici.KullaniciTip.Tip == kTip.Tip
            //     && y.IsActive == true)
            //    .Select(x => new AracListVM
            //    {
            //        MarkaAd = x.Marka.Ad,
            //        ModelAd = x.ArabaModel.Ad,
            //        KullaniciTip = x.Kullanici.KullaniciTip.Tip,
            //        StatuID = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().StatuID,
            //        StatuAd = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().Statu.StatuAd,
            //        KullaniciID = x.KullaniciID,
            //        KullaniciAd = x.Kullanici.KullaniciAd
            //    }).Where(C => C.StatuID == statu.StatuID).ToList();
            
            var aracList = FiltrelenenAraclariListele(y => y.MarkaID == marka.MarkaID && y.ModelID == model.ModelID && y.Kullanici.KullaniciTip.Tip == kTip.Tip
                  && y.IsActive == true).Where(c=>c.StatuID == statu.StatuID).ToList();


            return aracList;
        }
        
        public List<AracListVM> AracListele()
        {
            var aracList = ThisContext.Arac.Include("ArabaModel").Include("Calisan").Include("Kullanici").Include("Marka").Include("AracStatu")
                .Where(y => y.IsActive == true)
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

        public List<AracListVM> FiltrelenenAraclariListele(Expression<Func<Arac, bool>> expression)
        {
            var aracList = ThisContext.Arac
                .Where(expression)
                .Select(x=> new AracListVM
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
    }
}
