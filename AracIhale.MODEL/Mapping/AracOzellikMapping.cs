using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class AracOzellikMapping
    {
        public AracOzellik AracOzellikVMToAracOzellik(AracOzellikVM vm)
        {
            return new AracOzellik()
            {
                AracOzellikID = vm.AracOzellikID,
                AracID = vm.AracID,
                OzellikBilgiID = vm.OzellikBilgiID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public AracOzellikVM AracOzellikToAracOzellikVM(AracOzellik entity)
        {
            return new AracOzellikVM()
            {
                AracOzellikID = entity.AracOzellikID,
                AracID = entity.AracID,
                OzellikBilgiID = entity.OzellikBilgiID,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<AracOzellikVM> ListAracOzellikToListAracOzellikVM(List<AracOzellik> list)
        {
            List<AracOzellikVM> AracOzellikListVM = new List<AracOzellikVM>();
            foreach (AracOzellik item in list)
            {
                AracOzellikListVM.Add(AracOzellikToAracOzellikVM(item));
            }
            return AracOzellikListVM;
        }

        public List<AracOzellik> ListAracOzellikVMToListAracOzellik(List<AracOzellikVM> listVM)
        {
            List<AracOzellik> AracOzellikList = new List<AracOzellik>();
            foreach (AracOzellikVM item in listVM)
            {
                AracOzellikList.Add(AracOzellikVMToAracOzellik(item));
            }
            return AracOzellikList;
        }
    }
}
