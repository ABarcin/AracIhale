using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class FavoriIlanRepository : Repository<FavoriIlan>, IFavoriIlanRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public FavoriIlanRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
