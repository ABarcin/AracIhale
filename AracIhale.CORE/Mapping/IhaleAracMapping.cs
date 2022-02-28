using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class IhaleAracMapping
    {
        public IhaleArac IhaleAracVMToIhaleArac(IhaleAracVM vm)
        {
            return new IhaleArac()
            {
                IhaleAracID = vm.IhaleAracID,
                IhaleID = vm.IhaleID,
                AracID = vm.AracID,
                IhaleBaslangicFiyat = vm.IhaleBaslangicFiyat,
                MinAlimFiyati = vm.MinAlimFiyati,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IhaleAracVM IhaleAracToIhaleAracVM(IhaleArac entity)
        {
            return new IhaleAracVM()
            {
                IhaleAracID = entity.IhaleAracID,
                IhaleID = entity.IhaleID,
                AracID = entity.AracID,
                IhaleBaslangicFiyat = entity.IhaleBaslangicFiyat,
                MinAlimFiyati = entity.MinAlimFiyati,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<IhaleAracVM> ListIhaleAracToListIhaleAracVM(List<IhaleArac> list)
        {
            List<IhaleAracVM> IhaleAracListVM = null;
            foreach (IhaleArac item in list)
            {
                IhaleAracListVM.Add(IhaleAracToIhaleAracVM(item));
            }
            return IhaleAracListVM;
        }

        public List<IhaleArac> ListIhaleAracVMToListIhaleArac(List<IhaleAracVM> listVM)
        {
            List<IhaleArac> IhaleAracList = null;
            foreach (IhaleAracVM item in listVM)
            {
                IhaleAracList.Add(IhaleAracVMToIhaleArac(item));
            }
            return IhaleAracList;
        }
    }
}
