using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Mapping
{
    public class IlanMapping
    {
        public Ilan IlanVMToIlan(IlanVM vm)
        {
            return new Ilan()
            {
                IlanID = vm.IlanID,
                AracID = vm.AracID,
                Baslik = vm.Baslik,
                Aciklama = vm.Aciklama,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public IlanVM IlanToIlanVM(Ilan entity)
        {
            if(entity == null)
            {
                return null;
            }
            return new IlanVM()
            {
                IlanID = entity.IlanID,
                AracID = entity.AracID,
                Baslik = entity.Baslik,
                Aciklama = entity.Aciklama,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<IlanVM> ListIlanToListIlanVM(List<Ilan> list)
        {
            List<IlanVM> IlanListVM = null;
            foreach (Ilan item in list)
            {
                IlanListVM.Add(IlanToIlanVM(item));
            }
            return IlanListVM;
        }

        public List<Ilan> ListIlanVMToListIlan(List<IlanVM> listVM)
        {
            List<Ilan> IlanList = null;
            foreach (IlanVM item in listVM)
            {
                IlanList.Add(IlanVMToIlan(item));
            }
            return IlanList;
        }
    }
}

