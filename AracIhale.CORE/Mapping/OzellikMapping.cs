using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.CORE.Mapping
{
    public class OzellikMapping
    {
        public Ozellik OzellikVMToOzellik(OzellikVM vm)
        {
            return new Ozellik()
            {
                OzellikID = vm.OzellikID,
                OzellikAd = vm.OzellikAd,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public OzellikVM OzellikToOzellikVM(Ozellik ozellik)
        {
            return new OzellikVM()
            {
                OzellikID = ozellik.OzellikID,
                OzellikAd = ozellik.OzellikAd,
                IsActive = ozellik.IsActive,
                CreatedBy = ozellik.CreatedBy,
                CreatedDate = ozellik.CreatedDate,
                ModifiedBy = ozellik.ModifiedBy,
                ModifiedDate = ozellik.ModifiedDate
            };
        }

        public List<OzellikVM> ListOzellikToListOzellikVM(List<Ozellik> ozellikler)
        {
            List<OzellikVM> ozellikVM = null;
            foreach (Ozellik item in ozellikler)
            {
                ozellikVM.Add(OzellikToOzellikVM(item));
            }
            return ozellikVM;
        }
        public List<Ozellik> ListOzellikVMToListOzellik(List<OzellikVM> ozellikVM)
        {
            List<Ozellik> ozellikler = null;
            foreach (OzellikVM item in ozellikVM)
            {
                ozellikler.Add(OzellikVMToOzellik(item));
            }
            return ozellikler;
        }

    }
}
