using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class FavoriAramaKriterRepository : Repository<FavoriAramaKriter>, IFavoriAramaKriterRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public FavoriAramaKriterRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
