using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class IletisimTurRepository : Repository<IletisimTur>, IIletisimTurRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IletisimTurRepository(AracIhaleEntities context) : base(context)
        {
            
        }
        IletisimTurMapping mapping = new IletisimTurMapping();
        public List<IletisimTurVM> IletisimTurleriniGetir()
        {
            return mapping.ListIletisimTurToListIletisimTurVM( this.GetAll().ToList());
        }
    }
}
