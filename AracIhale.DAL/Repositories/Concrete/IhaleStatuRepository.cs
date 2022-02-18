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
    public class IhaleStatuRepository : Repository<IhaleStatu>, IIhaleStatuRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IhaleStatuRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<IhaleStatuVM> GetIhaleStatuVM()
        {
            IhaleStatuRepository ihaleStatuRepository = new IhaleStatuRepository(ThisContext);

            List<IhaleStatu> ihaleStatuler = ihaleStatuRepository.GetAll();

            List<IhaleStatuVM> ihaleStatuVMler = new IhaleStatuMapping().ListIhaleStatuToListIhaleStatuVM(ihaleStatuler);

            return ihaleStatuVMler;
        }
        public List<StatuVM> StatuleriListele()
        {
            var ihaleStatu = ThisContext.IhaleStatu.Select(x => new StatuVM
            {
                StatuAd = x.Durum,
                StatuID = x.IhaleStatuID,
                IsActive = x.IsActive,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate,
                ModifiedBy = x.ModifiedBy,
                ModifiedDate = x.ModifiedDate
            }).ToList();

            return ihaleStatu;
        }
    }
}
