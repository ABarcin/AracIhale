using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AracIhale.CORE.Login;
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
            .Where(y => y.IsActive == true)
            .Select(x => new IhaleListVM
            {
                IhaleID = x.IhaleID,
                IhaleAdi = x.IhaleAdi,
                KullaniciTip = x.KullaniciTip.Tip,
                IhaleBaslangic = x.IhaleBaslangic,
                IhaleBitis = x.IhaleBitis,
                BaslangicSaat = x.BaslangicSaat,
                BitisSaat = x.BitisSaat,
                IhaleStatuID = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatuID,
                IhaleDurum = ThisContext.IhaleSurec.Where(c => c.IhaleID == x.IhaleID).FirstOrDefault().IhaleStatu.Durum,
                KullaniciTipID = x.KullaniciTipID,
                KullaniciAd = ThisContext.Ihale.Where(v => v.IhaleID == x.IhaleID).Select(z => z.Calisan.KullaniciAd).FirstOrDefault(),
                CreatedDate = x.CreatedDate
            }).ToList();

            // Ihale adi bos degilse ihale adina gore filtreleme yapacak
            if (ihaleAdi != "")
            {
                ihaleList = ihaleList.Where(y => y.IhaleAdi == ihaleAdi && y.IsActive == true).ToList();
            }

            // Kullanici tipi null degilse kullanici tipine gore filteleme yapicak.
            if(kTip != null)
            {
                ihaleList = ihaleList.Where(y => y.KullaniciTipID == kTip.KullaniciTipID && y.IsActive == true).ToList();
            }

            // Statu null degilse statuye gore filtreleme yapicak.
            if(statu != null)
            {
                ihaleList = ihaleList.Where(y => y.IhaleStatuID == statu.StatuID && y.IsActive == true).ToList();
            }

            return ihaleList;
        }

        public void InsertIhaleVM(IhaleListVM ihaleListVM)
        {
            IhaleRepository ihaleRepository = new IhaleRepository(ThisContext);
            IhaleSurecRepository ihaleSurecRepository = new IhaleSurecRepository(ThisContext);

            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    ihaleRepository.Add(new IhaleListMapping().IhaleVMToIhale(ihaleListVM));

                    // Son ihaleyi alabilmek icin kaydedilmek zorunda.
                    ThisContext.SaveChanges();

                    int sonIhaleID = ihaleRepository.GetAll().Max(x => x.IhaleID);

                    ihaleSurecRepository.Add(new IhaleSurec() { 
                        IhaleID = sonIhaleID,
                        IhaleStatuID = ihaleListVM.IhaleStatuID,
                        Tarih = DateTime.Now
                    });

                    transaction.Complete();
                }

                catch(Exception e)
                {
                    
                }
            }
        }

        public void UpdateIhaleVM(IhaleListVM ihaleListVM)
        {
            IhaleRepository ihaleRepository = new IhaleRepository(ThisContext);
            IhaleSurecRepository ihaleSurecRepository = new IhaleSurecRepository(ThisContext);

            Ihale ihaleEntity = ihaleRepository.GetByID(ihaleListVM.IhaleID);
            IhaleSurec ihaleSurecEntity = ihaleSurecRepository
                .GetAll(x => x.IhaleID == ihaleListVM.IhaleID)
                .OrderByDescending(y => y.Tarih)
                .FirstOrDefault();

            ihaleEntity.IhaleAdi = ihaleListVM.IhaleAdi;
            ihaleEntity.KullaniciTipID = ihaleListVM.KullaniciTipID;
            ihaleEntity.IhaleBaslangic = ihaleListVM.IhaleBaslangic;
            ihaleEntity.IhaleBitis = ihaleListVM.IhaleBitis;
            ihaleEntity.BaslangicSaat = ihaleListVM.BaslangicSaat;
            ihaleEntity.BitisSaat = ihaleListVM.BitisSaat;
            ihaleEntity.ModifiedDate = DateTime.Now;
            ihaleEntity.ModifiedBy = Login.GirisYapmisCalisan.KullaniciAd;
            
            ihaleSurecEntity.IhaleStatuID = ihaleListVM.IhaleStatuID;
            ihaleSurecEntity.ModifiedDate = DateTime.Now;
            ihaleSurecEntity.ModifiedBy = Login.GirisYapmisCalisan.KullaniciAd;

            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    ihaleRepository.Update(ihaleEntity);
                    ihaleSurecRepository.Update(ihaleSurecEntity);

                    transaction.Complete();
                }

                catch(Exception e)
                {

                }
            }
        }
    }
}
