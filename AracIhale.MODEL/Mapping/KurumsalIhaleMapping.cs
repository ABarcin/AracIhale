using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.MODEL.Mapping
{
    public class KurumsalIhaleMapping
    {
        public KurumsalIhale KurumsalIhaleVMToKurumsalIhale(KurumsalIhaleVM vm)
        {
            return new KurumsalIhale()
            {
                KurumsalIhaleID = vm.KurumsalIhaleID,
                IhaleID = vm.IhaleID,
                FirmaID = vm.FirmaID,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public KurumsalIhaleVM KurumsalIhaleToKurumsalIhaleVM(KurumsalIhale kurumsalIhale)
        {
            return new KurumsalIhaleVM()
            {
                KurumsalIhaleID = kurumsalIhale.KurumsalIhaleID,
                IhaleID = kurumsalIhale.IhaleID,
                FirmaID = kurumsalIhale.FirmaID,
                IsActive = kurumsalIhale.IsActive,
                CreatedBy = kurumsalIhale.CreatedBy,
                CreatedDate = kurumsalIhale.CreatedDate,
                ModifiedBy = kurumsalIhale.ModifiedBy,
                ModifiedDate = kurumsalIhale.ModifiedDate
            };
        }

        public List<KurumsalIhaleVM> ListKurumsalIhaleToListKurumsalIhaleVM(List<KurumsalIhale> kurumsalIhaleler)
        {
            List<KurumsalIhaleVM> kurumsalIhaleVM = null;
            foreach (KurumsalIhale item in kurumsalIhaleler)
            {
                kurumsalIhaleVM.Add(KurumsalIhaleToKurumsalIhaleVM(item));
            }
            return kurumsalIhaleVM;
        }
        public List<KurumsalIhale> ListKurumsalIhaleVMToListKurumsalIhale(List<KurumsalIhaleVM> kurumsalIhaleVM)
        {
            List<KurumsalIhale> kurumsalIhaleler = null;
            foreach (KurumsalIhaleVM item in kurumsalIhaleVM)
            {
                kurumsalIhaleler.Add(KurumsalIhaleVMToKurumsalIhale(item));
            }
            return kurumsalIhaleler;
        }


    }
}
