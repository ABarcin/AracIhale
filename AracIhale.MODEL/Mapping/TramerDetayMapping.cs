using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class TramerDetayMapping
    {
        public TramerDetay TramerDetayVMToTramerDetay(TramerDetayVM vm)
        {
            return new TramerDetay()
            {
                TramerDetayID = vm.TramerDetayID,
                TramerDurum = vm.TramerDurum,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public TramerDetayVM TramerDetayToTramerDetayVM(TramerDetay entity)
        {
            return new TramerDetayVM()
            {
                TramerDetayID = entity.TramerDetayID,
                TramerDurum = entity.TramerDurum,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<TramerDetayVM> ListTramerDetayToListTramerDetayVM(List<TramerDetay> list)
        {
            List<TramerDetayVM> TramerDetayListVM = null;
            foreach (TramerDetay item in list)
            {
                TramerDetayListVM.Add(TramerDetayToTramerDetayVM(item));
            }
            return TramerDetayListVM;
        }

        public List<TramerDetay> ListTramerDetayVMToListTramerDetay(List<TramerDetayVM> listVM)
        {
            List<TramerDetay> TramerDetayList = null;
            foreach (TramerDetayVM item in listVM)
            {
                TramerDetayList.Add(TramerDetayVMToTramerDetay(item));
            }
            return TramerDetayList;
        }
    }
}

