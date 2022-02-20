using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class AracParcaMapping
    {
        public AracParca AracParcaVMToAracParca(AracParcaVM vm)
        {
            return new AracParca()
            {
                AracParcaID = vm.AracParcaID,
                ParcaAd = vm.ParcaAd,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public AracParcaVM AracParcaToAracParcaVM(AracParca entity)
        {
            return new AracParcaVM()
            {
                AracParcaID = entity.AracParcaID,
                ParcaAd = entity.ParcaAd,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<AracParcaVM> ListAracParcaToListAracParcaVM(List<AracParca> list)
        {
            List<AracParcaVM> AracParcaListVM = new List<AracParcaVM>();
            foreach (AracParca item in list)
            {
                AracParcaListVM.Add(AracParcaToAracParcaVM(item));
            }
            return AracParcaListVM;
        }

        public List<AracParca> ListAracParcaVMToListAracParca(List<AracParcaVM> listVM)
        {
            List<AracParca> AracParcaList = new List<AracParca>();
            foreach (AracParcaVM item in listVM)
            {
                AracParcaList.Add(AracParcaVMToAracParca(item));
            }
            return AracParcaList;
        }
    }
}
