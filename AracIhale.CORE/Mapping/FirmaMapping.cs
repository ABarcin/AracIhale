using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class FirmaMapping
    {
        public Firma FirmaVMToFirma(FirmaVM vm)
        {
            return new Firma()
            {
                FirmaID = vm.FirmaID,
                Unvan = vm.Unvan,
                SehirIlceID = vm.SehirIlceID,
                FirmaTipID = vm.FirmaTipID,
                PaketID = vm.PaketID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public FirmaVM FirmaToFirmaVM(Firma entity)
        {
            return new FirmaVM()
            {
                FirmaID = entity.FirmaID,
                Unvan = entity.Unvan,
                SehirIlceID = entity.SehirIlceID,
                FirmaTipID = entity.FirmaTipID,
                PaketID = entity.PaketID,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<FirmaVM> ListFirmaToListFirmaVM(List<Firma> list)
        {
            List<FirmaVM> FirmaListVM = new List<FirmaVM>();
            foreach (Firma item in list)
            {
                FirmaListVM.Add(FirmaToFirmaVM(item));
            }
            return FirmaListVM;
        }

        public List<Firma> ListFirmaVMToListFirma(List<FirmaVM> listVM)
        {
            List<Firma> FirmaList = new List<Firma>();
            foreach (FirmaVM item in listVM)
            {
                FirmaList.Add(FirmaVMToFirma(item));
            }
            return FirmaList;
        }
    }
}
