using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class FavoriIlanMapping
    {
        public FavoriIlan FavoriIlanVMToFavoriIlan(FavoriIlanVM vm)
        {
            return new FavoriIlan()
            {
                FavoriIlanID = vm.FavoriIlanID,
                KullaniciID = vm.KullaniciID,
                IlanID = vm.IlanID,
                Tarih = vm.Tarih,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FavoriIlanVM FavoriIlanToFavoriIlanVM(FavoriIlan entity)
        {
            return new FavoriIlanVM()
            {
                FavoriIlanID = entity.FavoriIlanID,
                KullaniciID = entity.KullaniciID,
                IlanID = entity.IlanID,
                Tarih = entity.Tarih,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FavoriIlanVM> ListFavoriIlanToListFavoriIlanVM(List<FavoriIlan> list)
        {
            List<FavoriIlanVM> FavoriIlanListVM = null;
            foreach (FavoriIlan item in list)
            {
                FavoriIlanListVM.Add(FavoriIlanToFavoriIlanVM(item));
            }
            return FavoriIlanListVM;
        }

        public List<FavoriIlan> ListFavoriIlanVMToListFavoriIlan(List<FavoriIlanVM> listVM)
        {
            List<FavoriIlan> FavoriIlanList = null;
            foreach (FavoriIlanVM item in listVM)
            {
                FavoriIlanList.Add(FavoriIlanVMToFavoriIlan(item));
            }
            return FavoriIlanList;
        }
    }
}
