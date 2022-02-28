using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class RolYetkiMapping
    {
        public RolYetki RolYetkiVMToRolYetki(RolYetkiVM vm)
        {
            return new RolYetki()
            {
                RolYetkiID = vm.RolYetkiID,
                RolID = vm.RolID,
                YetkiID = vm.YetkiID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public RolYetkiVM RolYetkiToRolYetkiVM(RolYetki RolYetki)
        {
            return new RolYetkiVM()
            {
                RolYetkiID = RolYetki.RolYetkiID,
                RolID = RolYetki.RolID,
                YetkiID = RolYetki.YetkiID,
                IsActive = RolYetki.IsActive,
                CreatedBy = RolYetki.CreatedBy,
                CreatedDate = RolYetki.CreatedDate,
                ModifiedBy = RolYetki.ModifiedBy,
                ModifiedDate = RolYetki.ModifiedDate
            };
        }

        public List<RolYetkiVM> ListRolYetkiToRolYetkiVM(List<RolYetki> RolYetkiler)
        {
            List<RolYetkiVM> RolYetkiListVM = new List<RolYetkiVM>();
            foreach (RolYetki item in RolYetkiler)
            {
                RolYetkiListVM.Add(RolYetkiToRolYetkiVM(item));
            }
            return RolYetkiListVM;
        }
        public List<RolYetki> ListRolYetkiVMToListRolYetki(List<RolYetkiVM> RolYetkilerVM)
        {
            List<RolYetki> RolYetkiList = new List<RolYetki>();
            foreach (RolYetkiVM item in RolYetkilerVM)
            {
                RolYetkiList.Add(RolYetkiVMToRolYetki(item));
            }
            return RolYetkiList;
        }
    }
}
