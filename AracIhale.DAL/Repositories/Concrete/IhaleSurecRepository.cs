using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class IhaleSurecRepository : Repository<IhaleSurec>, IIhaleSurecRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IhaleSurecRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
