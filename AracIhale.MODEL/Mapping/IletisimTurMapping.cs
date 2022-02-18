using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class IletisimTurMapping
    {
        public IletisimTur IletisimTurVMToIletisimTur(IletisimTurVM vm)
        {
            return new IletisimTur()
            {
                IletisimTuruID = vm.IletisimTuruID,
                Ad = vm.Ad,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IletisimTurVM IletisimTurToIletisimTurVM(IletisimTur iletisimTur)
        {
            return new IletisimTurVM()
            {
                IletisimTuruID = iletisimTur.IletisimTuruID,
                Ad = iletisimTur.Ad,
                IsActive = iletisimTur.IsActive,
                CreatedBy = iletisimTur.CreatedBy,
                CreatedDate = iletisimTur.CreatedDate,
                ModifiedBy = iletisimTur.ModifiedBy,
                ModifiedDate = iletisimTur.ModifiedDate
            };
        }

        public List<IletisimTurVM> ListIletisimTurToListIletisimTurVM(List<IletisimTur> iletisimTurler)
        {
            List<IletisimTurVM> iletisimTurVM = null;
            foreach (IletisimTur item in iletisimTurler)
            {
                iletisimTurVM.Add(IletisimTurToIletisimTurVM(item));
            }
            return iletisimTurVM;
        }
        public List<IletisimTur> ListIletisimTurVMToListIletisimTur(List<IletisimTurVM> iletisimTurlerVM)
        {
            List<IletisimTur> iletisimTurs = null;
            foreach (IletisimTurVM item in iletisimTurlerVM)
            {
                iletisimTurs.Add(IletisimTurVMToIletisimTur(item));
            }
            return iletisimTurs;
        }
    }
}
