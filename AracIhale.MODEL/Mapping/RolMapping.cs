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
        public RolVM RolToRolVM(Rol entity)
        {
            return new RolVM()
            {
                RolID = entity.RolID,
                Ad = entity.Ad,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
                ModifiedDate = entity.ModifiedDate
            };
        }

        public List<RolVM> ListRolToRolVM(List<Rol> entity)
        {
            List<RolVM> RolListVM = new List<RolVM>();
            foreach (Rol item in entity)
            {
                RolListVM.Add(RolToRolVM(item));
            }
            return RolListVM;
        }
        public List<Rol> ListRolVMToListRol(List<RolVM> vm)
        {
            List<Rol> RolList = new List<Rol>();
            foreach (RolVM item in vm)
            {
                RolList.Add(RolVMToRol(item));
            }
            return RolList;
        }
    }
}
