using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class OzellikBilgiMapping
    {
        public OzellikBilgi OzellikBilgiVMToOzellikBilgi(OzellikBilgiVM vm)
        {
            return new OzellikBilgi()
            {
                OzellikBilgiID = vm.OzellikBilgiID,
                OzellikDetay = vm.OzellikDetay,
                OzellikID = vm.OzellikID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public OzellikBilgiVM OzellikBilgiToOzellikBilgiVM(OzellikBilgi ozellikBilgi)
        {
            return new OzellikBilgiVM()
            {
                OzellikBilgiID = ozellikBilgi.OzellikBilgiID,
                OzellikDetay = ozellikBilgi.OzellikDetay,
                OzellikID = ozellikBilgi.OzellikID,
                IsActive = ozellikBilgi.IsActive,
                CreatedBy = ozellikBilgi.CreatedBy,
                CreatedDate = ozellikBilgi.CreatedDate,
                ModifiedBy = ozellikBilgi.ModifiedBy,
                ModifiedDate = ozellikBilgi.ModifiedDate
            };
        }

        public List<OzellikBilgiVM> ListOzellikBilgiToListOzellikBilgiVM(List<OzellikBilgi> ozellikBilgiler)
        {
            List<OzellikBilgiVM> ozellikBilgiVM = null;
            foreach (OzellikBilgi item in ozellikBilgiler)
            {
                ozellikBilgiVM.Add(OzellikBilgiToOzellikBilgiVM(item));
            }
            return ozellikBilgiVM;
        }
        public List<OzellikBilgi> ListOzellikBilgiVMToListOzellikBilgi(List<OzellikBilgiVM> ozellikBilgiVM)
        {
            List<OzellikBilgi> ozellikBilgiler = null;
            foreach (OzellikBilgiVM item in ozellikBilgiVM)
            {
                ozellikBilgiler.Add(OzellikBilgiVMToOzellikBilgi(item));
            }
            return ozellikBilgiler;
        }
    }
}
