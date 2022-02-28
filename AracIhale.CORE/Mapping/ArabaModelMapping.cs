using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class ArabaModelMapping
    {
        public ArabaModel ArabaModelVMToArabaModel(ArabaModelVM vm)
        {
            return new ArabaModel()
            {
                Ad = vm.Ad,
                ModelID = vm.ModelID,
                MarkaID = vm.MarkaID,
                UstModelID = vm.UstModelID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public ArabaModelVM ArabaModelToArabaModelVM(ArabaModel arabaModel)
        {
            return new ArabaModelVM()
            {
                Ad = arabaModel.Ad,
                ModelID = arabaModel.ModelID,
                MarkaID = arabaModel.MarkaID,
                UstModelID = arabaModel.UstModelID,
                IsActive = arabaModel.IsActive,
                CreatedBy = arabaModel.CreatedBy,
                CreatedDate = arabaModel.CreatedDate,
                ModifiedBy = arabaModel.ModifiedBy,
                ModifiedDate = arabaModel.ModifiedDate
            };
        }

        public List<ArabaModelVM> ListArabaModelToListArabaModelVM(List<ArabaModel> arabalar)
        {
            List<ArabaModelVM> arabalarListVM = null;
            foreach (ArabaModel item in arabalar)
            {
                arabalarListVM.Add(ArabaModelToArabaModelVM(item));
            }
            return arabalarListVM;
        }

        public List<ArabaModel> ListArabaModelVMToListArabaModel(List<ArabaModelVM> arabalarVM)
        {
            List<ArabaModel> arabalarList = null;
            foreach (ArabaModelVM item in arabalarVM)
            {
                arabalarList.Add(ArabaModelVMToArabaModel(item));
            }
            return arabalarList;
        }
    }
}
