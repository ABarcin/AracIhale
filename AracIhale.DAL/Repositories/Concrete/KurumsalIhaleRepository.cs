using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class KurumsalIhaleRepository : Repository<KurumsalIhale>, IKurumsalIhaleRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public KurumsalIhaleRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
