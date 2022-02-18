using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class KullaniciMapping
    {
        public Kullanici KullaniciVMToKullanici(KullaniciVM vm)
        {
            return new Kullanici()
            {
                KullaniciID = vm.KullaniciID,
                KullaniciAd = vm.KullaniciAd,
                KullaniciTipID = vm.KullaniciTipID,
                Sifre = vm.Sifre,
                RolID = vm.RolID,
                Ad = vm.Ad,
                Soyad = vm.Soyad,
                KVKK = vm.KVKK,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public KullaniciVM KullaniciToKullaniciVM(Kullanici kullanici)
        {
            return new KullaniciVM()
            {
                KullaniciID = kullanici.KullaniciID,
                KullaniciAd = kullanici.KullaniciAd,
                KullaniciTipID = kullanici.KullaniciTipID,
                Sifre = kullanici.Sifre,
                RolID = kullanici.RolID,
                Ad = kullanici.Ad,
                Soyad = kullanici.Soyad,
                KVKK = kullanici.KVKK,
                IsActive = kullanici.IsActive,
                CreatedBy = kullanici.CreatedBy,
                CreatedDate = kullanici.CreatedDate,
                ModifiedBy = kullanici.ModifiedBy,
                ModifiedDate = kullanici.ModifiedDate
            };
        }

        public List<KullaniciVM> ListKullaniciToListKullaniciVM(List<Kullanici> kullanicilar)
        {
            List<KullaniciVM> kullaniciVM = null;
            foreach (Kullanici item in kullanicilar)
            {
                kullaniciVM.Add(KullaniciToKullaniciVM(item));
            }
            return kullaniciVM;
        }
        public List<Kullanici> ListKullaniciVMToListKullanici(List<KullaniciVM> kullaniciVM)
        {
            List<Kullanici> kullanicilar = null;
            foreach (KullaniciVM item in kullaniciVM)
            {
                kullanicilar.Add(KullaniciVMToKullanici(item));
            }
            return kullanicilar;
        }
    }
}
