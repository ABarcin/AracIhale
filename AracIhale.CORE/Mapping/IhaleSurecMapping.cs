using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class IhaleSurecMapping
    {
        public IhaleSurec IhaleSurecVMToIhaleSurec(IhaleSurecVM vm)
        {
            return new IhaleSurec()
            {
                StatuIhaleID = vm.StatuIhaleID,
                IhaleID = vm.IhaleID,
                IhaleStatuID = vm.IhaleStatuID,
                Tarih = vm.Tarih,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IhaleSurecVM IhaleSurecToIhaleSurecVM(IhaleSurec entity)
        {
            return new IhaleSurecVM()
            {
                StatuIhaleID = entity.StatuIhaleID,
                IhaleID = entity.IhaleID,
                IhaleStatuID = entity.IhaleStatuID,
                Tarih = entity.Tarih,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<IhaleSurecVM> ListIhaleSurecToListIhaleSurecVM(List<IhaleSurec> list)
        {
            List<IhaleSurecVM> IhaleSurecListVM = null;
            foreach (IhaleSurec item in list)
            {
                IhaleSurecListVM.Add(IhaleSurecToIhaleSurecVM(item));
            }
            return IhaleSurecListVM;
        }

        public List<IhaleSurec> ListIhaleSurecVMToListIhaleSurec(List<IhaleSurecVM> listVM)
        {
            List<IhaleSurec> IhaleSurecList = null;
            foreach (IhaleSurecVM item in listVM)
            {
                IhaleSurecList.Add(IhaleSurecVMToIhaleSurec(item));
            }
            return IhaleSurecList;
        }
    }
}
