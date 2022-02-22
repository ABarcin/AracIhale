using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class AracTramerDetayMapping
    {
        public AracTramerDetay AracTramerDetayVMToAracTramerDetay(AracTramerDetayVM vm)
        {
            return new AracTramerDetay()
            {
                AracParcaID = vm.AracParcaID,
                AracTramerDetayID = vm.AracTramerDetayID,
                AracTramerID = vm.AracTramerID,
                TramerDetayID = vm.TramerDetayID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public AracTramerDetayVM AracTramerDetayToAracTramerDetayVM(AracTramerDetay entity)
        {
            return new AracTramerDetayVM()
            {
                AracParcaID = entity.AracParcaID,
                AracTramerDetayID = entity.AracTramerDetayID,
                AracTramerID = entity.AracTramerID,
                TramerDetayID = entity.TramerDetayID,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }
        public List<AracTramerDetayVM> ListAracTramerDetayToListAracTramerDetayVM(List<AracTramerDetay> list)
        {
            List<AracTramerDetayVM> aracTramerListVM = new List<AracTramerDetayVM>();
            foreach (AracTramerDetay item in list)
            {
                aracTramerListVM.Add(AracTramerDetayToAracTramerDetayVM(item));
            }
            return aracTramerListVM;
        }
        public List<AracTramerDetay> ListAracTramerDetayVMToListAracTramerDetay(List<AracTramerDetayVM> listVM)
        {
            List<AracTramerDetay> aracTramerDetayList = new List<AracTramerDetay>();
            foreach (AracTramerDetayVM item in listVM)
            {
                aracTramerDetayList.Add(AracTramerDetayVMToAracTramerDetay(item));
            }
            return aracTramerDetayList;
        }
    }
}
