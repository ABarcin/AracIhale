using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class FavoriAramaMapping
    {
        public FavoriArama FavoriAramaVMToFavoriArama(FavoriAramaVM vm)
        {
            return new FavoriArama()
            {
                FavoriAramaID = vm.FavoriAramaID,
                FavoriAramaKriterID = vm.FavoriAramaKriterID,
                KullaniciID = vm.KullaniciID,
                Ad = vm.Ad,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public FavoriAramaVM FavoriAramaToFavoriAramaVM(FavoriArama FavoriArama)
        {
            return new FavoriAramaVM()
            {
                FavoriAramaID = FavoriArama.FavoriAramaID,
                Ad = FavoriArama.Ad,
                IsActive = FavoriArama.IsActive,
                CreatedBy = FavoriArama.CreatedBy,
                CreatedDate = FavoriArama.CreatedDate,
                ModifiedBy = FavoriArama.ModifiedBy,
                ModifiedDate = FavoriArama.ModifiedDate
            };
        }

        public List<FavoriAramaVM> ListFavoriAramaToFavoriAramaVM(List<FavoriArama> FavoriAramaler)
        {
            List<FavoriAramaVM> FavoriAramaListVM = null;
            foreach (FavoriArama item in FavoriAramaler)
            {
                FavoriAramaListVM.Add(FavoriAramaToFavoriAramaVM(item));
            }
            return FavoriAramaListVM;
        }
        public List<FavoriArama> ListFavoriAramaVMToListFavoriArama(List<FavoriAramaVM> FavoriAramalerVM)
        {
            List<FavoriArama> FavoriAramaList = null;
            foreach (FavoriAramaVM item in FavoriAramalerVM)
            {
                FavoriAramaList.Add(FavoriAramaVMToFavoriArama(item));
            }
            return FavoriAramaList;
        }
    }
}
