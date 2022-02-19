using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class KullaniciIletisimMapping
    {
        public KullaniciIletisim KullaniciIletisimVMToKullaniciIletisim(KullaniciIletisimVM vm)
        {
            return new KullaniciIletisim()
            {
                KullaniciIletisimID = vm.KullaniciIletisimID,
                IletisimTuruID = vm.IletisimTuruID,
                KullaniciID = vm.KullaniciID,
                IletisimBilgi = vm.IletisimBilgi,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public KullaniciIletisimVM KullaniciIletisimToKullaniciIletisimVM(KullaniciIletisim kullaniciIletisim)
        {
            return new KullaniciIletisimVM()
            {
                KullaniciIletisimID = kullaniciIletisim.KullaniciIletisimID,
                IletisimTuruID = kullaniciIletisim.IletisimTuruID,
                KullaniciID = kullaniciIletisim.KullaniciID,
                IletisimBilgi = kullaniciIletisim.IletisimBilgi,
                IsActive = kullaniciIletisim.IsActive,
                CreatedBy = kullaniciIletisim.CreatedBy,
                CreatedDate = kullaniciIletisim.CreatedDate,
                ModifiedBy = kullaniciIletisim.ModifiedBy,
                ModifiedDate = kullaniciIletisim.ModifiedDate
            };
        }

        public List<KullaniciIletisimVM> ListKullaniciIletisimToListKullaniciIletisimVM(List<KullaniciIletisim> kullaniciIletisimler)
        {
            List<KullaniciIletisimVM> kullaniciIletisimVM = null;
            foreach (KullaniciIletisim item in kullaniciIletisimler)
            {
                kullaniciIletisimVM.Add(KullaniciIletisimToKullaniciIletisimVM(item));
            }
            return kullaniciIletisimVM;
        }
        public List<KullaniciIletisim> ListKullaniciIletisimVMToListKullaniciIletisim(List<KullaniciIletisimVM> kullaniciIletisimVM)
        {
            List<KullaniciIletisim> kullaniciIletisimler = null;
            foreach (KullaniciIletisimVM item in kullaniciIletisimVM)
            {
                kullaniciIletisimler.Add(KullaniciIletisimVMToKullaniciIletisim(item));
            }
            return kullaniciIletisimler;
        }



    }
}
