using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class IhaleMapping
    {
        public Ihale IhaleVMToIhale(IhaleVM vm)
        {
            return new Ihale()
            {
                IhaleID = vm.IhaleID,
                IhaleAdi = vm.IhaleAdi,
                CalisanID = vm.CalisanID,
                KullaniciTipID = vm.KullaniciTipID,
                IhaleBaslangic = vm.IhaleBaslangic,
                IhaleBitis = vm.IhaleBitis,
                BaslangicSaat = vm.BaslangicSaat,
                BitisSaat = vm.BitisSaat,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IhaleVM IhaleToIhaleVM(Ihale entity)
        {
            return new IhaleVM()
            {
                IhaleID = entity.IhaleID,
                IhaleAdi = entity.IhaleAdi,
                CalisanID = entity.CalisanID,
                KullaniciTipID = entity.KullaniciTipID,
                IhaleBaslangic = entity.IhaleBaslangic,
                IhaleBitis = entity.IhaleBitis,
                BaslangicSaat = entity.BaslangicSaat,
                BitisSaat = entity.BitisSaat,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<IhaleVM> ListIhaleToListIhaleVM(List<Ihale> list)
        {
            List<IhaleVM> IhaleListVM = null;
            foreach (Ihale item in list)
            {
                IhaleListVM.Add(IhaleToIhaleVM(item));
            }
            return IhaleListVM;
        }

        public List<Ihale> ListIhaleVMToListIhale(List<IhaleVM> listVM)
        {
            List<Ihale> IhaleList = null;
            foreach (IhaleVM item in listVM)
            {
                IhaleList.Add(IhaleVMToIhale(item));
            }
            return IhaleList;
        }
    }
}
