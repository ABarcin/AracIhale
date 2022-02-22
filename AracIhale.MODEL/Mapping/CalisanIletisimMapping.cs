using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class CalisanIletisimMapping
    {
        public CalisanIletisim CalisanIletisimVMToCalisanIletisim(CalisanIletisimVM vm)
        {
            return new CalisanIletisim()
            {
                CalisanID = vm.CalisanID,
                IletisimBilgi = vm.IletisimBilgi,
                IletisimTuruID = vm.IletisimTuruID,
                CalisanIletisimID=vm.CalisanIletisimID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public CalisanIletisimVM CalisanIletisimToCalisanIletisimVM(CalisanIletisim entity)
        {
            return new CalisanIletisimVM()
            {
                CalisanID = entity.CalisanID,
                CalisanIletisimID = entity.CalisanIletisimID,
                IletisimBilgi = entity.IletisimBilgi,
                IletisimTuruID = entity.IletisimTuruID,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
                ModifiedDate = entity.ModifiedDate
            };
        }
        public List<CalisanIletisimVM> ListCalisanIletisimToListCalisanIletisimVM(List<CalisanIletisim> list)
        {
            List<CalisanIletisimVM> CalisanIletisimListVM = new List<CalisanIletisimVM>();
            foreach (CalisanIletisim item in list)
            {
                CalisanIletisimListVM.Add(CalisanIletisimToCalisanIletisimVM(item));
            }
            return CalisanIletisimListVM;
        }
        public List<CalisanIletisim> ListCalisanIletisimVMToListCalisanIletisim(List<CalisanIletisimVM> listVM)
        {
            List<CalisanIletisim> calisanIletisimList = null;
            foreach (CalisanIletisimVM item in listVM)
            {
                calisanIletisimList.Add(CalisanIletisimVMToCalisanIletisim(item));
            }
            return calisanIletisimList;
        }
    }
}
