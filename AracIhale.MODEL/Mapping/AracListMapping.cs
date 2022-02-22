using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class AracListMapping
    {
        //public Arac AracListVMToArac(AracListVM vm)
        //{
        //    return new Arac()
        //    {
        //        AracID = vm.AracID,
        //        KullaniciID = vm.KullaniciID,
        //        MarkaID = vm.,
        //        ModelID = vm.ModelID,
        //        IsActive = vm.IsActive,
        //        CreatedBy = vm.CreatedBy,
        //        CreatedDate = vm.CreatedDate,
        //        ModifiedBy = vm.ModifiedBy,
        //        ModifiedDate = vm.ModifiedDate
        //    };
        //}
        public AracListVM AracToAracListVM(Arac arac)
        {
            return new AracListVM()
            {
                AracID = arac.AracID,
                KullaniciID = arac.KullaniciID,
                MarkaAd = arac.Marka.Ad,
                ModelAd = arac.ArabaModel.Ad,
                IsActive = arac.IsActive,
                CreatedBy = arac.CreatedBy,
                CreatedDate = arac.CreatedDate,
                ModifiedBy = arac.ModifiedBy,
            };
        }
        public List<AracListVM> ListAracToListAracVM(List<Arac> araclar)
        {
            List<AracListVM> araclarListVM = new List<AracListVM>();
            foreach (Arac item in araclar)
            {
                araclarListVM.Add(AracToAracListVM(item));
            }
            return araclarListVM;
        }
        //public List<Arac> ListAracVMToListArac(List<AracListVM> araclarVM)
        //{
        //    List<Arac> araclarList = new List<Arac>();
        //    foreach (AracListVM item in araclarVM)
        //    {
        //        araclarList.Add(AracListVMToArac(item));
        //    }
        //    return araclarList;
        //}
    }
}
