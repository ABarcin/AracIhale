using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class FavoriOzellikMapping
    {
        public FavoriOzellik FavoriOzellikVMToFavoriOzellik(FavoriOzellikVM vm)
        {
            return new FavoriOzellik()
            {
                FavoriOzellikID = vm.FavoriOzellikID,
                OzellikBilgiID = vm.OzellikBilgiID,
                FavoriAramaKriterID = vm.FavoriAramaKriterID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FavoriOzellikVM FavoriOzellikToFavoriOzellikVM(FavoriOzellik entity)
        {
            return new FavoriOzellikVM()
            {
                FavoriOzellikID = entity.FavoriOzellikID,
                OzellikBilgiID = entity.OzellikBilgiID,
                FavoriAramaKriterID = entity.FavoriAramaKriterID,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FavoriOzellikVM> ListFavoriOzellikToListFavoriOzellikVM(List<FavoriOzellik> list)
        {
            List<FavoriOzellikVM> FavoriOzellikListVM = null;
            foreach (FavoriOzellik item in list)
            {
                FavoriOzellikListVM.Add(FavoriOzellikToFavoriOzellikVM(item));
            }
            return FavoriOzellikListVM;
        }

        public List<FavoriOzellik> ListFavoriOzellikVMToListFavoriOzellik(List<FavoriOzellikVM> listVM)
        {
            List<FavoriOzellik> FavoriOzellikList = null;
            foreach (FavoriOzellikVM item in listVM)
            {
                FavoriOzellikList.Add(FavoriOzellikVMToFavoriOzellik(item));
            }
            return FavoriOzellikList;
        }
    }
}
