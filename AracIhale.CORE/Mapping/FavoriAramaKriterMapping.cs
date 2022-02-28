using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class FavoriAramaKriterMapping
    {
        public FavoriAramaKriter FavoriAramaKriterVMToFavoriAramaKriter(FavoriAramaKriterVM vm)
        {
            return new FavoriAramaKriter()
            {
                FavoriAramaKriterID = vm.FavoriAramaKriterID,
                MarkaID = vm.MarkaID,
                ModelID = vm.ModelID,
                BaslangicYil = vm.BaslangicYil,
                BitisYil = vm.BitisYil,
                BaslangicFiyat = vm.BaslangicFiyat,
                BitisFiyat = vm.BitisFiyat,
                BaslangicKM = vm.BaslangicKM,
                BitisKM = vm.BitisKM,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FavoriAramaKriterVM FavoriAramaKriterToFavoriAramaKriterVM(FavoriAramaKriter entity)
        {
            return new FavoriAramaKriterVM()
            {
                FavoriAramaKriterID = entity.FavoriAramaKriterID,
                MarkaID = entity.MarkaID,
                ModelID = entity.ModelID,
                BaslangicYil = entity.BaslangicYil,
                BitisYil = entity.BitisYil,
                BaslangicFiyat = entity.BaslangicFiyat,
                BitisFiyat = entity.BitisFiyat,
                BaslangicKM = entity.BaslangicKM,
                BitisKM = entity.BitisKM,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FavoriAramaKriterVM> ListFavoriAramaKriterToListFavoriAramaKriterVM(List<FavoriAramaKriter> list)
        {
            List<FavoriAramaKriterVM> FavoriAramaKriterListVM = null;
            foreach (FavoriAramaKriter item in list)
            {
                FavoriAramaKriterListVM.Add(FavoriAramaKriterToFavoriAramaKriterVM(item));
            }
            return FavoriAramaKriterListVM;
        }

        public List<FavoriAramaKriter> ListFavoriAramaKriterVMToListFavoriAramaKriter(List<FavoriAramaKriterVM> listVM)
        {
            List<FavoriAramaKriter> FavoriAramaKriterList = null;
            foreach (FavoriAramaKriterVM item in listVM)
            {
                FavoriAramaKriterList.Add(FavoriAramaKriterVMToFavoriAramaKriter(item));
            }
            return FavoriAramaKriterList;
        }
    }
}
