using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class MarkaRepository : Repository<Marka>, IMarkaRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public MarkaRepository(AracIhaleEntities context) : base(context)
        {

        }
        public List<MarkaVM> TumMarkalar()
        {
            var tumMarkalar = ThisContext.Marka.Select(x => new MarkaVM
            {
                Ad = x.Ad,
                MarkaID = x.MarkaID,
                IsActive = x.IsActive,
                CreatedBy = x.CreatedBy,
                CreatedDate = x.CreatedDate,
                ModifiedBy = x.ModifiedBy,
                ModifiedDate = x.ModifiedDate
            }).ToList();

            return tumMarkalar;
        }
    }
}
