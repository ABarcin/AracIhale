using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class StokMapping
    {
        public Stok StokVMToStok(StokVM vm)
        {
            return new Stok()
            {
                StokID = vm.StokID,
                FirmaID = vm.FirmaID,
                StokAdeti = vm.StokAdeti,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public StokVM StokToStokVM(Stok entity)
        {
            return new StokVM()
            {
                StokID = entity.StokID,
                FirmaID = entity.FirmaID,
                StokAdeti = entity.StokAdeti,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<StokVM> ListStokToListStokVM(List<Stok> list)
        {
            List<StokVM> StokListVM = null;
            foreach (Stok item in list)
            {
                StokListVM.Add(StokToStokVM(item));
            }
            return StokListVM;
        }

        public List<Stok> ListStokVMToListStok(List<StokVM> listVM)
        {
            List<Stok> StokList = null;
            foreach (StokVM item in listVM)
            {
                StokList.Add(StokVMToStok(item));
            }
            return StokList;
        }
    }
}

