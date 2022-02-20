using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class AracStatuRepository : Repository<AracStatu>, IAracStatuRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracStatuRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<StatuVM> StatuleriListele()
        {
            var aracStatu = ThisContext.Statu.Select(x => new StatuVM
            {
                StatuAd = x.StatuAd,
                StatuID = x.StatuID,
                IsActive = x.IsActive,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate,
                ModifiedBy = x.ModifiedBy,
                ModifiedDate = x.ModifiedDate
            }).ToList();

            return aracStatu;
        }

        public void AracStatuEkle(AracStatuVM aracStatuVM)
        {
            AracStatu eklenecekAracStatu = new AracStatuMapping().AracStatuVMToAracStatu(aracStatuVM);
            this.Add(eklenecekAracStatu);
        }
    }
}
