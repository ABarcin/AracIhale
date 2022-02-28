using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class AracTeklifMapping
    {
        public AracTeklif AracTeklifVMToAracTeklif(AracTeklifVM vm)
        {
            return new AracTeklif()
            {
                AracTeklifID = vm.AracTeklifID,
                IhaleAracID = vm.IhaleAracID,
                KullaniciID = vm.KullaniciID,
                TeklifFiyat = vm.TeklifFiyat,
                Tarih = vm.Tarih,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public AracTeklifVM AracTeklifToAracTeklifVM(AracTeklif entity)
        {
            return new AracTeklifVM()
            {
                AracTeklifID = entity.AracTeklifID,
                IhaleAracID = entity.IhaleAracID,
                KullaniciID = entity.KullaniciID,
                TeklifFiyat = entity.TeklifFiyat,
                Tarih = entity.Tarih,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }
        public List<AracTeklifVM> ListAracTeklifToListAracTeklifVM(List<AracTeklif> list)
        {
            List<AracTeklifVM> aracTeklifListVM = null;
            foreach (AracTeklif item in list)
            {
                aracTeklifListVM.Add(AracTeklifToAracTeklifVM(item));
            }
            return aracTeklifListVM;
        }
        public List<AracTeklif> ListAracTeklifVMToListAracTeklif(List<AracTeklifVM> listVM)
        {
            List<AracTeklif> aracTeklifList = null;
            foreach (AracTeklifVM item in listVM)
            {
                aracTeklifList.Add(AracTeklifVMToAracTeklif(item));
            }
            return aracTeklifList;
        }
    }
}
