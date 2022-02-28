using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class EkspertizMapping
    {
        public Ekspertiz EkspertizVMToEkspertiz(EkspertizVM vm)
        {
            return new Ekspertiz()
            {
                EkspertizID = vm.EkspertizID,
                Ad = vm.Ad,
                Adres = vm.Adres,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public EkspertizVM EkspertizToEkspertizVM(Ekspertiz Ekspertiz)
        {
            return new EkspertizVM()
            {
                EkspertizID = Ekspertiz.EkspertizID,
                Ad = Ekspertiz.Ad,
                Adres = Ekspertiz.Adres,
                IsActive = Ekspertiz.IsActive,
                CreatedBy = Ekspertiz.CreatedBy,
                CreatedDate = Ekspertiz.CreatedDate,
                ModifiedBy = Ekspertiz.ModifiedBy,
                ModifiedDate = Ekspertiz.ModifiedDate
            };
        }

        public List<EkspertizVM> ListEkspertizToEkspertizVM(List<Ekspertiz> Ekspertizler)
        {
            List<EkspertizVM> EkspertizListVM = null;
            foreach (Ekspertiz item in Ekspertizler)
            {
                EkspertizListVM.Add(EkspertizToEkspertizVM(item));
            }
            return EkspertizListVM;
        }
        public List<Ekspertiz> ListEkspertizVMToListEkspertiz(List<EkspertizVM> EkspertizlerVM)
        {
            List<Ekspertiz> EkspertizList = null;
            foreach (EkspertizVM item in EkspertizlerVM)
            {
                EkspertizList.Add(EkspertizVMToEkspertiz(item));
            }
            return EkspertizList;
        }
    }
}
