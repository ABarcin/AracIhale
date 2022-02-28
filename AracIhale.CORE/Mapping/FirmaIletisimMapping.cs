using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class FirmaIletisimMapping
    {
        public FirmaIletisim FirmaIletisimVMToFirmaIletisim(FirmaIletisimVM vm)
        {
            return new FirmaIletisim()
            {
                FirmaIletisimID = vm.FirmaIletisimID,
                IletisimTuruID = vm.IletisimTuruID,
                FirmaID = vm.FirmaID,
                IletisimBilgi = vm.IletisimBilgi,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FirmaIletisimVM FirmaIletisimToFirmaIletisimVM(FirmaIletisim entity)
        {
            return new FirmaIletisimVM()
            {
                FirmaIletisimID = entity.FirmaIletisimID,
                IletisimTuruID = entity.IletisimTuruID,
                FirmaID = entity.FirmaID,
                IletisimBilgi = entity.IletisimBilgi,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FirmaIletisimVM> ListFirmaIletisimToListFirmaIletisimVM(List<FirmaIletisim> list)
        {
            List<FirmaIletisimVM> FirmaIletisimListVM = null;
            foreach (FirmaIletisim item in list)
            {
                FirmaIletisimListVM.Add(FirmaIletisimToFirmaIletisimVM(item));
            }
            return FirmaIletisimListVM;
        }

        public List<FirmaIletisim> ListFirmaIletisimVMToListFirmaIletisim(List<FirmaIletisimVM> listVM)
        {
            List<FirmaIletisim> FirmaIletisimList = null;
            foreach (FirmaIletisimVM item in listVM)
            {
                FirmaIletisimList.Add(FirmaIletisimVMToFirmaIletisim(item));
            }
            return FirmaIletisimList;
        }
    }
}
