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
    public class IhaleRepository : Repository<Ihale>, IIhaleRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IhaleRepository(AracIhaleEntities context) : base(context)
        {

        }

        /// <summary>
        /// Veri tabanindan gerekli sartlara gore filtreleyerek
        /// ilgili ihaleyi getiren metod.
        /// </summary>
        /// <param name="ihaleAdi">Ihale adi</param>
        /// <param name="kTip">Kullanici tipi</param>
        /// <param name="statu">Ihale statusu</param>
        /// <returns></returns>
        public List<IhaleListVM> IhaleListele(string ihaleAdi="", KullaniciTipVM kTip=null, StatuVM statu=null)
        {
            var ihaleList = ThisContext.Ihale.Include("Calisan").Include("Kullanici").Include("Statu").Include("IhaleSurec").Include("IhaleStatu")
            .Select(x => new IhaleListVM
            {
                IhaleID = x.IhaleID,
                IhaleAdi = x.IhaleAdi,
                KullaniciTip = x.KullaniciTip.Tip,
                IhaleBaslangic = x.IhaleBaslangic,
                IhaleBitis = x.IhaleBitis,
                IhaleStatuID = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatuID,
                IhaleDurum = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatu.Durum,
                KullaniciAd = ThisContext.Ihale.Where(v => v.IhaleID == x.IhaleID).Select(z => z.Calisan.KullaniciAd).FirstOrDefault(),
                CreatedDate = x.CreatedDate
            }).ToList();

            // Ihale adi bos degilse ihale adina gore filtreleme yapacak
            if (ihaleAdi != "")
            {
                ihaleList = ihaleList.Where(y => y.IhaleAdi == ihaleAdi && y.IsActive == true)
                .Select(x => new IhaleListVM
                {
                    IhaleID = x.IhaleID,
                    IhaleAdi = x.IhaleAdi,
                    KullaniciTip = x.KullaniciTip,
                    IhaleBaslangic = x.IhaleBaslangic,
                    IhaleBitis = x.IhaleBitis,
                    IhaleStatuID = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatuID,
                    IhaleDurum = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatu.Durum,
                    KullaniciAd = ThisContext.Ihale.Where(v => v.IhaleID == x.IhaleID).Select(z => z.Calisan.KullaniciAd).FirstOrDefault(),
                    CreatedDate = x.CreatedDate
                }).ToList();
            }

            // Kullanici tipi null degilse kullanici tipine gore filteleme yapicak.
            if(kTip != null)
            {
                ihaleList = ihaleList.Where(y => y.KullaniciTipID == kTip.KullaniciTipID && y.IsActive == true)
                .Select(x => new IhaleListVM
                {
                    IhaleID = x.IhaleID,
                    IhaleAdi = x.IhaleAdi,
                    KullaniciTip = x.KullaniciTip,
                    IhaleBaslangic = x.IhaleBaslangic,
                    IhaleBitis = x.IhaleBitis,
                    IhaleStatuID = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatuID,
                    IhaleDurum = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatu.Durum,
                    KullaniciAd = ThisContext.Ihale.Where(v => v.IhaleID == x.IhaleID).Select(z => z.Calisan.KullaniciAd).FirstOrDefault(),
                    CreatedDate = x.CreatedDate
                }).ToList();
            }

            // Statu null degilse statuye gore filtreleme yapicak.
            if(statu != null)
            {
                ihaleList = ihaleList.Where(y => y.IhaleStatuID == statu.StatuID && y.IsActive == true)
                .Select(x => new IhaleListVM
                {
                    IhaleID = x.IhaleID,
                    IhaleAdi = x.IhaleAdi,
                    KullaniciTip = x.KullaniciTip,
                    IhaleBaslangic = x.IhaleBaslangic,
                    IhaleBitis = x.IhaleBitis,
                    IhaleStatuID = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatuID,
                    IhaleDurum = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatu.Durum,
                    KullaniciAd = ThisContext.Ihale.Where(v => v.IhaleID == x.IhaleID).Select(z => z.Calisan.KullaniciAd).FirstOrDefault(),
                    CreatedDate = x.CreatedDate
                }).ToList();
            }

            //ihaleList = ThisContext.Ihale.Include("Calisan").Include("Kullanici").Include("Statu").Include("IhaleSurec").Include("IhaleStatu")
            //    .Where(y => y.IhaleAdi == ihaleAdi && y.KullaniciTipID == kTip.KullaniciTipID
            //     && y.IsActive == true)
            //    .Select(x => new IhaleListVM
            //    {
            //        IhaleID = x.IhaleID,
            //        IhaleAdi = x.IhaleAdi,
            //        KullaniciTip = x.KullaniciTip.Tip,
            //        IhaleBaslangic = x.IhaleBaslangic,
            //        IhaleBitis = x.IhaleBitis,
            //        IhaleStatuID = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatuID,
            //        IhaleDurum = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatu.Durum,
            //        KullaniciAd = ThisContext.Ihale.Where(v => v.IhaleID == x.IhaleID).Select(z => z.Calisan.KullaniciAd).FirstOrDefault(),
            //        CreatedDate = x.CreatedDate
            //    }).ToList();

            return ihaleList;
        }

        public void InsertIhaleVM(IhaleListVM ihaleListVM)
        {
            IhaleRepository ihaleRepository = new IhaleRepository(ThisContext);

            ihaleRepository.Add(new IhaleListMapping().IhaleVMToIhale(ihaleListVM));
        }

        public void UpdateIhaleVM(IhaleListVM ihaleListVM)
        {
            IhaleRepository ihaleRepository = new IhaleRepository(ThisContext);

            ihaleRepository.Update(new IhaleListMapping().IhaleVMToIhale(ihaleListVM));
        }
    }
}
