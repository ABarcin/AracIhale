using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayfaIhale.MODEL.Mapping
{
    public class SayfaMapping
    {
        public Sayfa SayfaVMToSayfa(SayfaVM vm)
        {
            return new Sayfa()
            {
                SayfaID = vm.SayfaID,
                SayfaAdi = vm.SayfaAdi,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public SayfaVM SayfaToSayfaVM(Sayfa Sayfa)
        {
            return new SayfaVM()
            {
                SayfaID = Sayfa.SayfaID,
                SayfaAdi = Sayfa.SayfaAdi,
                IsActive = Sayfa.IsActive,
                CreatedBy = Sayfa.CreatedBy,
                CreatedDate = Sayfa.CreatedDate,
                ModifiedBy = Sayfa.ModifiedBy,
            };
        }
        public List<SayfaVM> ListSayfaToListSayfaVM(List<Sayfa> Sayfalar)
        {
            List<SayfaVM> SayfalarListVM = null;
            foreach (Sayfa item in Sayfalar)
            {
                SayfalarListVM.Add(SayfaToSayfaVM(item));
            }
            return SayfalarListVM;
        }
        public List<Sayfa> ListSayfaVMToListSayfa(List<SayfaVM> SayfalarVM)
        {
            List<Sayfa> SayfalarList = null;
            foreach (SayfaVM item in SayfalarVM)
            {
                SayfalarList.Add(SayfaVMToSayfa(item));
            }
            return SayfalarList;
        }
    }
}
