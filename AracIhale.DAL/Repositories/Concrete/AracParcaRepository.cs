using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class AracParcaRepository : Repository<AracParca>, IAracParcaRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracParcaRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<AracParcaVM> AracParcaListesiGetir()
        {
            return new AracParcaMapping().ListAracParcaToListAracParcaVM(GetAll());
        }
    }
}
