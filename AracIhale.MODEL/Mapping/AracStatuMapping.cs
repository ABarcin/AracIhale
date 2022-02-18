using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class AracStatuMapping
    {
        public AracStatu AracStatuVMToAracStatu(AracStatuVM vm)
        {
            return new AracStatu()
            {
                AracID = vm.AracID,
                StatuID = vm.StatuID,
                AracStatuID = vm.AracStatuID,
                Tarih = vm.Tarih,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public AracStatuVM AracStatuToAracStatuVM(AracStatu aracStatu)
        {
            return new AracStatuVM()
            {
                AracID = aracStatu.AracID,
                StatuID = aracStatu.StatuID,
                AracStatuID = aracStatu.AracStatuID,
                Tarih = aracStatu.Tarih,
                IsActive = aracStatu.IsActive,
                CreatedBy = aracStatu.CreatedBy,
                CreatedDate = aracStatu.CreatedDate,
                ModifiedBy = aracStatu.ModifiedBy,
            };
        }
        public List<AracStatuVM> ListAracStatuToListAracStatuVM(List<AracStatu> aracStatuler)
        {
            List<AracStatuVM> aracStatuListVM = null;
            foreach (AracStatu item in aracStatuler)
            {
                aracStatuListVM.Add(AracStatuToAracStatuVM(item));
            }
            return aracStatuListVM;
        }
        public List<AracStatu> ListAracStatuVMToListAracStatu(List<AracStatuVM> aracStatulerVM)
        {
            List<AracStatu> aracStatuList = null;
            foreach (AracStatuVM item in aracStatulerVM)
            {
                aracStatuList.Add(AracStatuVMToAracStatu(item));
            }
            return aracStatuList;
        }
    }
}
