using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class FirmaIletisimRepository : Repository<FirmaIletisim>, IFirmaIletisimRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public FirmaIletisimRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
