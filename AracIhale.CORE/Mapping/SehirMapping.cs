using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class SehirMapping
    {
        public Sehir SehirVMToSehir(SehirVM vm)
        {
            return new Sehir()
            {
                SehirID = vm.SehirID,
                Ad = vm.Ad,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public SehirVM SehirToSehirVM(Sehir Sehir)
        {
            return new SehirVM()
            {
                SehirID = Sehir.SehirID,
                Ad = Sehir.Ad,
                IsActive = Sehir.IsActive,
                CreatedBy = Sehir.CreatedBy,
                CreatedDate = Sehir.CreatedDate,
                ModifiedBy = Sehir.ModifiedBy,
                ModifiedDate = Sehir.ModifiedDate
            };
        }

        public List<SehirVM> ListSehirToSehirVM(List<Sehir> Sehirler)
        {
            List<SehirVM> SehirListVM = null;
            foreach (Sehir item in Sehirler)
            {
                SehirListVM.Add(SehirToSehirVM(item));
            }
            return SehirListVM;
        }
        public List<Sehir> ListSehirVMToListSehir(List<SehirVM> SehirlerVM)
        {
            List<Sehir> SehirList = null;
            foreach (SehirVM item in SehirlerVM)
            {
                SehirList.Add(SehirVMToSehir(item));
            }
            return SehirList;
        }
    }
}
