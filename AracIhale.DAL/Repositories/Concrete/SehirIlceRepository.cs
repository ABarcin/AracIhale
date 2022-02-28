using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class SehirIlceRepository : Repository<SehirIlce>, ISehirIlceRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public SehirIlceRepository(AracIhaleEntities context) : base(context)
        {

        }
    }
}
