using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class ArabaModelRepository : Repository<ArabaModel>, IArabaModelRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public ArabaModelRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<ArabaModelVM> ModelListele(MarkaVM marka)
        {
            var tumModeller = ThisContext.ArabaModel.Where(x => x.MarkaID == marka.MarkaID)
                .Select(y => new ArabaModelVM
            {
                Ad = y.Ad,
                ModelID = y.ModelID,
                MarkaID = y.MarkaID,
                UstModelID = y.UstModelID,
                IsActive = y.IsActive,
                CreatedBy = y.CreatedBy,
                CreatedDate = y.CreatedDate,
                ModifiedBy = y.ModifiedBy,
                ModifiedDate = y.ModifiedDate
            }).ToList();

            return tumModeller;
        }
    }
}
