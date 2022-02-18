using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class CalisanMapping
    {
        public Calisan CalisanVMToCalisan(CalisanVM vm)
        {
            return new Calisan()
            {
                CalisanID = vm.CalisanID,
                Ad = vm.Ad,
                Soyad = vm.Soyad,
                KullaniciAd = vm.KullaniciAd,
                Sifre = vm.Sifre,
                RolID = vm.RolID,
                AktiflikDurumu = vm.AktiflikDurumu,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public CalisanVM CalisanToCalisanVM(Calisan entity)
        {
            return new CalisanVM()
            {
                CalisanID = entity.CalisanID,
                Ad = entity.Ad,
                Soyad = entity.Soyad,
                KullaniciAd = entity.KullaniciAd,
                Sifre = entity.Sifre,
                RolID = entity.RolID,
                AktiflikDurumu = entity.AktiflikDurumu,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }
        public List<CalisanVM> ListCalisanToListCalisanVM(List<Calisan> list)
        {
            List<CalisanVM> CalisanListVM = new List<CalisanVM>();
            foreach (Calisan item in list)
            {
                CalisanListVM.Add(CalisanToCalisanVM(item));
            }
            return CalisanListVM;
        }
        public List<Calisan> ListCalisanVMToListCalisan(List<CalisanVM> listVM)
        {
            List<Calisan> CalisanList = new List<Calisan>();
            foreach (CalisanVM item in listVM)
            {
                CalisanList.Add(CalisanVMToCalisan(item));
            }
            return CalisanList;
        }
    }
}
