using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class FirmaTipMapping
    {
        public FirmaTip FirmaTipVMToFirmaTip(FirmaTipVM vm)
        {
            return new FirmaTip()
            {
                FirmaTipID = vm.FirmaTipID,
                FirmaTur = vm.FirmaTur,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FirmaTipVM FirmaTipToFirmaTipVM(FirmaTip entity)
        {
            return new FirmaTipVM()
            {
                FirmaTipID = entity.FirmaTipID,
                FirmaTur = entity.FirmaTur,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FirmaTipVM> ListFirmaTipToListFirmaTipVM(List<FirmaTip> list)
        {
            List<FirmaTipVM> FirmaTipListVM = null;
            foreach (FirmaTip item in list)
            {
                FirmaTipListVM.Add(FirmaTipToFirmaTipVM(item));
            }
            return FirmaTipListVM;
        }

        public List<FirmaTip> ListFirmaTipVMToListFirmaTip(List<FirmaTipVM> listVM)
        {
            List<FirmaTip> FirmaTipList = null;
            foreach (FirmaTipVM item in listVM)
            {
                FirmaTipList.Add(FirmaTipVMToFirmaTip(item));
            }
            return FirmaTipList;
        }
    }
}
