using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class SehirIlceMapping
    {
        public SehirIlce SehirIlceVMToSehirIlce(SehirIlceVM vm)
        {
            return new SehirIlce()
            {
                SehirIlceID = vm.SehirIlceID,
                SehirID = vm.SehirID,
                IlceID = vm.IlceID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public SehirIlceVM SehirIlceToSehirIlceVM(SehirIlce SehirIlce)
        {
            return new SehirIlceVM()
            {
                SehirIlceID = SehirIlce.SehirIlceID,
                SehirID = SehirIlce.SehirID,
                IlceID = SehirIlce.IlceID,
                IsActive = SehirIlce.IsActive,
                CreatedBy = SehirIlce.CreatedBy,
                CreatedDate = SehirIlce.CreatedDate,
                ModifiedBy = SehirIlce.ModifiedBy,
                ModifiedDate = SehirIlce.ModifiedDate
            };
        }

        public List<SehirIlceVM> ListSehirIlceToSehirIlceVM(List<SehirIlce> SehirIlceler)
        {
            List<SehirIlceVM> SehirIlceListVM = null;
            foreach (SehirIlce item in SehirIlceler)
            {
                SehirIlceListVM.Add(SehirIlceToSehirIlceVM(item));
            }
            return SehirIlceListVM;
        }
        public List<SehirIlce> ListSehirIlceVMToListSehirIlce(List<SehirIlceVM> SehirIlcelerVM)
        {
            List<SehirIlce> SehirIlceList = null;
            foreach (SehirIlceVM item in SehirIlcelerVM)
            {
                SehirIlceList.Add(SehirIlceVMToSehirIlce(item));
            }
            return SehirIlceList;
        }
    }
}
