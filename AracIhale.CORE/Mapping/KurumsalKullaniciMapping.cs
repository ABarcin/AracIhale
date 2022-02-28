using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.CORE.Mapping
{
    public class KurumsalKullaniciMapping
    {
        public KurumsalKullanici KurumsalKullaniciVMToKurumsalKullanici(KurumsalKullaniciVM vm)
        {
            return new KurumsalKullanici()
            {
                KurumsalKullaniciID = vm.KurumsalKullaniciID,
                KullaniciID = vm.KullaniciID,
                FirmaID = vm.FirmaID,
                OnayDurum = vm.OnayDurum,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public KurumsalKullaniciVM KurumsalKullaniciToKurumsalKullaniciVM(KurumsalKullanici kurumsalKullanici)
        {
            return new KurumsalKullaniciVM()
            {
                KurumsalKullaniciID = kurumsalKullanici.KurumsalKullaniciID,
                KullaniciID = kurumsalKullanici.KullaniciID,
                FirmaID = kurumsalKullanici.FirmaID,
                OnayDurum = kurumsalKullanici.OnayDurum,
                IsActive = kurumsalKullanici.IsActive,
                CreatedBy = kurumsalKullanici.CreatedBy,
                CreatedDate = kurumsalKullanici.CreatedDate,
                ModifiedBy = kurumsalKullanici.ModifiedBy,
                ModifiedDate = kurumsalKullanici.ModifiedDate
            };
        }

        public List<KurumsalKullaniciVM> ListKurumsalKullaniciToListKurumsalKullaniciVM(List<KurumsalKullanici> kurumsalKullanicilar)
        {
            List<KurumsalKullaniciVM> kurumsalKullaniciVM = new List<KurumsalKullaniciVM>();
            foreach (KurumsalKullanici item in kurumsalKullanicilar)
            {
                kurumsalKullaniciVM.Add(KurumsalKullaniciToKurumsalKullaniciVM(item));
            }
            return kurumsalKullaniciVM;
        }
        public List<KurumsalKullanici> ListKurumsalKullaniciVMToListKurumsalKullanici(List<KurumsalKullaniciVM> kurumsalKullaniciVM)
        {
            List<KurumsalKullanici> kurumsalKullanicilar = new List<KurumsalKullanici>();
            foreach (KurumsalKullaniciVM item in kurumsalKullaniciVM)
            {
                kurumsalKullanicilar.Add(KurumsalKullaniciVMToKurumsalKullanici(item));
            }
            return kurumsalKullanicilar;
        }



    }
}
