using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class PaketMapping
    {
        public Paket PaketVMToPaket(PaketVM vm)
        {
            return new Paket()
            {
                PaketID = vm.PaketID,
                Ad = vm.Ad,
                AracLimiti = vm.AracLimiti,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }
        public PaketVM PaketToPaketVM(Paket paket)
        {
            return new PaketVM()
            {
                PaketID = paket.PaketID,
                Ad = paket.Ad,
                AracLimiti = paket.AracLimiti,
                IsActive = paket.IsActive,
                CreatedBy = paket.CreatedBy,
                CreatedDate = paket.CreatedDate,
                ModifiedBy = paket.ModifiedBy,
                ModifiedDate = paket.ModifiedDate
            };
        }

        public List<PaketVM> ListPaketToPaketVM(List<Paket> paketler)
        {
            List<PaketVM> paketListVM = null;
            foreach (Paket item in paketler)
            {
                paketListVM.Add(PaketToPaketVM(item));
            }
            return paketListVM;
        }
        public List<Paket> ListPaketVMToListPaket(List<PaketVM> paketlerVM)
        {
            List<Paket> paketList = null;
            foreach (PaketVM item in paketlerVM)
            {
                paketList.Add(PaketVMToPaket(item));
            }
            return paketList;
        }
    }
}
