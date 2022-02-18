using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class AracMapping
    {
        public Arac AracVMToArac(AracVM vm)
        {
            return new Arac()
            {
                AracID=vm.AracID,
                Km=vm.Km,
                KullaniciAd=vm.KullaniciAd,
                MarkaID=vm.MarkaID,
                ModelID=vm.ModelID,
                Yıl=vm.Yıl,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public AracVM AracToAracVM(Arac arac)
        {
            return new AracVM()
            {
                AracID = arac.AracID,
                Km = arac.Km,
                KullaniciAd = arac.KullaniciAd,
                MarkaID = arac.MarkaID,
                ModelID = arac.ModelID,
                Yıl = arac.Yıl,
                IsActive = arac.IsActive,
                CreatedBy = arac.CreatedBy,
                CreatedDate = arac.CreatedDate,
                ModifiedBy = arac.ModifiedBy,
            };
        }
        public List<AracVM> ListAracToListAracVM(List<Arac> araclar)
        {
            List<AracVM> araclarListVM = null;
            foreach (Arac item in araclar)
            {
                araclarListVM.Add(AracToAracVM(item));
            }
            return araclarListVM;
        }
        public List<Arac> ListAracVMToListArac(List<AracVM> araclarVM)
        {
            List<Arac> araclarList = null;
            foreach (AracVM item in araclarVM)
            {
                araclarList.Add(AracVMToArac(item));
            }
            return araclarList;
        }
    }
}
