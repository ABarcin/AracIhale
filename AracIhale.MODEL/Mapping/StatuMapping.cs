using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Mapping
{
    public class StatuMapping
    {
        public Statu StatuVMToStatu(StatuVM vm)
        {
            return new Statu()
            {
                StatuID = vm.StatuID,
                StatuAd = vm.StatuAd,
                IsActive = vm.IsActive,
                CreatedBy = vm.CreatedBy,
                CreatedDate = vm.CreatedDate,
                ModifiedBy = vm.ModifiedBy,
                ModifiedDate = vm.ModifiedDate
            };
        }

        public StatuVM StatuToStatuVM(Statu entity)
        {
            return new StatuVM()
            {
                StatuID = entity.StatuID,
                StatuAd = entity.StatuAd,
                IsActive = entity.IsActive,
                CreatedBy = entity.CreatedBy,
                CreatedDate = entity.CreatedDate,
                ModifiedBy = entity.ModifiedBy,
            };
        }

        public List<StatuVM> ListStatuToListStatuVM(List<Statu> list)
        {
            List<StatuVM> StatuListVM = null;
            foreach (Statu item in list)
            {
                StatuListVM.Add(StatuToStatuVM(item));
            }
            return StatuListVM;
        }

        public List<Statu> ListStatuVMToListStatu(List<StatuVM> listVM)
        {
            List<Statu> StatuList = null;
            foreach (StatuVM item in listVM)
            {
                StatuList.Add(StatuVMToStatu(item));
            }
            return StatuList;
        }
    }
}
