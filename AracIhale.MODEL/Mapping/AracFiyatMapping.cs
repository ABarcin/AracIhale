using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class AracFiyatMapping
    {
        public AracFiyat AracFiyatVMToAracFiyat(AracFiyatVM vm)
        {
            return new AracFiyat()
            {
                AracFiyatID = vm.AracFiyatID,
                AracID = vm.AracID,
                Fiyat = vm.Fiyat,
                Tarih = vm.Tarih,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public AracFiyatVM AracFiyatToAracFiyatVM(AracFiyat entity)
        {
            return new AracFiyatVM()
            {
                AracFiyatID = entity.AracFiyatID,
                AracID = entity.AracID,
                Fiyat = entity.Fiyat,
                Tarih = entity.Tarih,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<AracFiyatVM> ListAracFiyatToListAracFiyatVM(List<AracFiyat> list)
        {
            List<AracFiyatVM> AracFiyatListVM = null;
            foreach (AracFiyat item in list)
            {
                AracFiyatListVM.Add(AracFiyatToAracFiyatVM(item));
            }
            return AracFiyatListVM;
        }

        public List<AracFiyat> ListAracFiyatVMToListAracFiyat(List<AracFiyatVM> listVM)
        {
            List<AracFiyat> AracFiyatList = null;
            foreach (AracFiyatVM item in listVM)
            {
                AracFiyatList.Add(AracFiyatVMToAracFiyat(item));
            }
            return AracFiyatList;
        }
    }
}
