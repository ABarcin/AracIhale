using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.CORE.Mapping
{
    public class MarkaMapping
    {
        public Marka MarkaVMToMarka(MarkaVM vm)
        {
            return new Marka()
            {
                MarkaID = vm.MarkaID,
                Ad = vm.Ad,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public MarkaVM MarkaToMarkaVM(Marka marka)
        {
            return new MarkaVM()
            {
                MarkaID = marka.MarkaID,
                Ad = marka.Ad,
                IsActive = marka.IsActive,
                CreatedBy = marka.CreatedBy,
                CreatedDate = marka.CreatedDate,
                ModifiedBy = marka.ModifiedBy,
                ModifiedDate = marka.ModifiedDate
            };
        }

        public List<MarkaVM> ListMarkaToListMarkaVM(List<Marka> markalar)
        {
            List<MarkaVM> markaVM = null;
            foreach (Marka item in markalar)
            {
                markaVM.Add(MarkaToMarkaVM(item));
            }
            return markaVM;
        }
        public List<Marka> ListMarkaVMToListMarka(List<MarkaVM> markaVM)
        {
            List<Marka> markalar = null;
            foreach (MarkaVM item in markaVM)
            {
                markalar.Add(MarkaVMToMarka(item));
            }
            return markalar;
        }



    }
}
