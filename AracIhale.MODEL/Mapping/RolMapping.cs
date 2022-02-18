using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class RolMapping
    {
        public Rol RolVMToRol(RolVM vm)
        {
            return new Rol()
            {
                RolID = vm.RolID,
                Ad = vm.Ad,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public RolVM RolToRolVM(Rol Rol)
        {
            return new RolVM()
            {
                RolID = Rol.RolID,
                Ad = Rol.Ad,
                IsActive = Rol.IsActive,
                CreatedBy = Rol.CreatedBy,
                CreatedDate = Rol.CreatedDate,
                ModifiedBy = Rol.ModifiedBy,
                ModifiedDate = Rol.ModifiedDate
            };
        }

        public List<RolVM> ListRolToRolVM(List<Rol> Roller)
        {
            List<RolVM> RolListVM = null;
            foreach (Rol item in Roller)
            {
                RolListVM.Add(RolToRolVM(item));
            }
            return RolListVM;
        }
        public List<Rol> ListRolVMToListRol(List<RolVM> RollerVM)
        {
            List<Rol> RolList = null;
            foreach (RolVM item in RollerVM)
            {
                RolList.Add(RolVMToRol(item));
            }
            return RolList;
        }
    }
}
