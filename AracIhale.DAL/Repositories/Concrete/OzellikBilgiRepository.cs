using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class OzellikBilgiRepository : Repository<OzellikBilgi>, IOzellikBilgiRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public OzellikBilgiRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
