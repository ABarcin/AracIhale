using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
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

        public List<IhaleListVM> IhaleListele(string ihaleAdi, KullaniciTipVM kTip, StatuVM statu)
        {

            var ihaleList = ThisContext.Ihale.Include("Calisan").Include("Kullanici").Include("Statu").Include("IhaleSurec").Include("IhaleStatu")
                .Where(y => y.IhaleAdi == ihaleAdi && y.KullaniciTipID == kTip.KullaniciTipID
                 && y.IsActive == true)
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

            foreach (IhaleListVM item in ihaleList)
            {
                if (true)
                {

                }
            }
            

            return ihaleList;
        }
    }
}
