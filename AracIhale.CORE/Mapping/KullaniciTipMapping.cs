using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.CORE.Mapping
{
    public class KullaniciTipMapping
    {
        public KullaniciTip KullaniciTipVMToKullaniciTip(KullaniciTipVM vm)
        {
            return new KullaniciTip()
            {
                KullaniciTipID = vm.KullaniciTipID,
                Tip = vm.Tip,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public KullaniciTipVM KullaniciTipToKullaniciTipVM(KullaniciTip kullaniciTip)
        {
            return new KullaniciTipVM()
            {
                KullaniciTipID = kullaniciTip.KullaniciTipID,
                Tip = kullaniciTip.Tip,
                IsActive = kullaniciTip.IsActive,
                CreatedBy = kullaniciTip.CreatedBy,
                CreatedDate = kullaniciTip.CreatedDate,
                ModifiedBy = kullaniciTip.ModifiedBy,
                ModifiedDate = kullaniciTip.ModifiedDate
            };
        }

        public List<KullaniciTipVM> ListKullaniciTipToListKullaniciTipVM(List<KullaniciTip> kullaniciTipleri)
        {
            List<KullaniciTipVM> kullaniciTipVM = new List<KullaniciTipVM>();
            foreach (KullaniciTip item in kullaniciTipleri)
            {
                kullaniciTipVM.Add(KullaniciTipToKullaniciTipVM(item));
            }
            return kullaniciTipVM;
        }
        public List<KullaniciTip> ListKullaniciTipVMToListKullaniciTip(List<KullaniciTipVM> kullaniciTipVM)
        {
            List<KullaniciTip> kullaniciTipleri = new List<KullaniciTip>();
            foreach (KullaniciTipVM item in kullaniciTipVM)
            {
                kullaniciTipleri.Add(KullaniciTipVMToKullaniciTip(item));
            }
            return kullaniciTipleri;
        }
    }
}
