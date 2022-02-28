using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class AracTramerMapping
    {
        public AracTramer AracTramerVMToAracTramer(AracTramerVM vm)
        {
            return new AracTramer()
            {
                AracID = vm.AracID,
                AracTramerID = vm.AracTramerID,
                Fiyat = vm.Fiyat,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public AracTramerVM AracTramerToAracTramerVM(AracTramer entity)
        {
            if (entity == null)
            {
                return null;
            }
            return new AracTramerVM()
            {
                AracID = entity.AracID,
                AracTramerID = entity.AracTramerID,
                Fiyat = entity.Fiyat,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }
        public List<AracTramerVM> ListAracTramerToListAracTramerVM(List<AracTramer> list)
        {
            List<AracTramerVM> aracTramerListVM = null;
            foreach (AracTramer item in list)
            {
                aracTramerListVM.Add(AracTramerToAracTramerVM(item));
            }
            return aracTramerListVM;
        }
        public List<AracTramer> ListAracTramerVMToListAracTramer(List<AracTramerVM> listVM)
        {
            List<AracTramer> aracTramerList = null;
            foreach (AracTramerVM item in listVM)
            {
                aracTramerList.Add(AracTramerVMToAracTramer(item));
            }
            return aracTramerList;
        }
    }
}
