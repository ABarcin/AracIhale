using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class FotografMapping
    {
        public Fotograf FotografVMToFotograf(FotografVM vm)
        {
            return new Fotograf()
            {
                FotografID = vm.FotografID,
                FotoPath = vm.FotoPath,
                AracID = vm.AracID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FotografVM FotografToFotografVM(Fotograf entity)
        {
            return new FotografVM()
            {
                FotografID = entity.FotografID,
                FotoPath = entity.FotoPath,
                AracID = entity.AracID,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FotografVM> ListFotografToListFotografVM(List<Fotograf> list)
        {
            List<FotografVM> FotografListVM = null;
            foreach (Fotograf item in list)
            {
                FotografListVM.Add(FotografToFotografVM(item));
            }
            return FotografListVM;
        }

        public List<Fotograf> ListFotografVMToListFotograf(List<FotografVM> listVM)
        {
            List<Fotograf> FotografList = null;
            foreach (FotografVM item in listVM)
            {
                FotografList.Add(FotografVMToFotograf(item));
            }
            return FotografList;
        }
    }
}
