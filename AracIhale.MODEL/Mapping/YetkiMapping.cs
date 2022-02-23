using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class YetkiMapping
    {
        public Yetki YetkiVMToYetki(YetkiVM vm)
        {
            return new Yetki()
            {
                YetkiID = vm.YetkiID,
                YetkiAciklama = vm.YetkiAciklama,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public YetkiVM YetkiToYetkiVM(Yetki Yetki)
        {
            return new YetkiVM()
            {
                YetkiID = Yetki.YetkiID,
                YetkiAciklama = Yetki.YetkiAciklama,
                IsActive = Yetki.IsActive,
                CreatedBy = Yetki.CreatedBy,
                CreatedDate = Yetki.CreatedDate,
                ModifiedBy = Yetki.ModifiedBy,
                ModifiedDate = Yetki.ModifiedDate
            };
        }

        public List<YetkiVM> ListYetkiToListYetkiVM(List<Yetki> Yetkiler)
        {
            List<YetkiVM> YetkiListVM = new List<YetkiVM>();
            foreach (Yetki item in Yetkiler)
            {
                YetkiListVM.Add(YetkiToYetkiVM(item));
            }
            return YetkiListVM;
        }
        public List<Yetki> ListYetkiVMToListYetki(List<YetkiVM> YetkilerVM)
        {
            List<Yetki> YetkiList = new List<Yetki>();
            foreach (YetkiVM item in YetkilerVM)
            {
                YetkiList.Add(YetkiVMToYetki(item));
            }
            return YetkiList;
        }
    }
}
