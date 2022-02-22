using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

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
