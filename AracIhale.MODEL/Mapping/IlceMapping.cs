using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class IlceMapping
    {
        public Ilce IlceVMToIlce(IlceVM vm)
        {
            return new Ilce() {
                IlceID = vm.IlceID,
                Ad = vm.Ad,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IlceVM IlceToIlceVM(Ilce ilce)
        {
            return new IlceVM() {
                IlceID = ilce.IlceID,
                Ad = ilce.Ad,
                IsActive = ilce.IsActive,
                CreatedBy = ilce.CreatedBy,
                CreatedDate = ilce.CreatedDate,
                ModifiedBy = ilce.ModifiedBy,
                ModifiedDate = ilce.ModifiedDate
            };
        }

        public List<IlceVM> ListIlceToListIlceVM(List<Ilce> ilceler)
        {
            List<IlceVM> ilcelerListVM = null;
            foreach (Ilce item in ilceler)
            {
                ilcelerListVM.Add(IlceToIlceVM(item));
            }
            return ilcelerListVM;
        }
        public List<Ilce> ListIlceVMToListIlce(List<IlceVM> ilcelerVM)
        {
            List<Ilce> ilcelerList = null;
            foreach (IlceVM item in ilcelerVM)
            {
                ilcelerList.Add(IlceVMToIlce(item));
            }
            return ilcelerList;
        }
    }
}
