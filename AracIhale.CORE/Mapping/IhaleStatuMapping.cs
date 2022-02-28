using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class IhaleStatuMapping
    {
        public IhaleStatu IhaleStatuVMToIhaleStatu(IhaleStatuVM vm)
        {
            return new IhaleStatu()
            {
                IhaleStatuID = vm.IhaleStatuID,
                Durum = vm.Durum,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IhaleStatuVM IhaleStatuToIhaleStatuVM(IhaleStatu entity)
        {
            return new IhaleStatuVM()
            {
                IhaleStatuID = entity.IhaleStatuID,
                Durum = entity.Durum,   
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<IhaleStatuVM> ListIhaleStatuToListIhaleStatuVM(List<IhaleStatu> list)
        {
            List<IhaleStatuVM> IhaleStatuListVM = new List<IhaleStatuVM>();
            foreach (IhaleStatu item in list)
            {
                IhaleStatuListVM.Add(IhaleStatuToIhaleStatuVM(item));
            }
            return IhaleStatuListVM;
        }

        public List<IhaleStatu> ListIhaleStatuVMToListIhaleStatu(List<IhaleStatuVM> listVM)
        {
            List<IhaleStatu> IhaleStatuList = new List<IhaleStatu>();
            foreach (IhaleStatuVM item in listVM)
            {
                IhaleStatuList.Add(IhaleStatuVMToIhaleStatu(item));
            }
            return IhaleStatuList;
        }
    }
}
