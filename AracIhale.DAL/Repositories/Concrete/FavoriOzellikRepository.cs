using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class FavoriOzellikRepository : Repository<FavoriOzellik>, IFavoriOzellikRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public FavoriOzellikRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
