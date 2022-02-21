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
        public List<AracListVM> AracListele(MarkaVM marka, ArabaModelVM model, KullaniciTipVM kTip, StatuVM statu)
        {
            var aracList = ThisContext.Arac.Include("ArabaModel").Include("Calisan").Include("Kullanici").Include("Marka").Include("Statu").Include("AracStatu")
                .Where(y => y.MarkaID == marka.MarkaID && y.ModelID == model.ModelID && y.Kullanici.KullaniciTip.Tip == kTip.Tip
                 && y.IsActive == true)
                .Select(x => new AracListVM
                {
                    MarkaAd = x.Marka.Ad,
                    ModelAd = x.ArabaModel.Ad,
                    KullaniciTip = x.Kullanici.KullaniciTip.Tip,
                    StatuID = x.AracStatu.Where(y=>y.IsActive == true).FirstOrDefault().StatuID,
                    StatuAd = x.AracStatu.Where(y => y.IsActive == true).FirstOrDefault().Statu.StatuAd,
                    CreatedDate = x.CreatedDate
                }).Where(C=>C.StatuID==statu.StatuID).ToList();

            return aracList;
        }

        public List<AracListVM> AracVMListele()
        {
            var aracList = ThisContext.Arac.Include("ArabaModel").Include("Kullanici").Include("Marka").ToList();

            return new AracListMapping().ListAracToListAracVM(aracList);
        }
    }
}
