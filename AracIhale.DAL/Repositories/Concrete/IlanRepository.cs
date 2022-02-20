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
    public class IlanRepository : Repository<Ilan>, IIlanRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public IlanRepository(AracIhaleEntities context) : base(context)
        {

        }

        /// <summary>
        /// Arac ID'sine gore IlanVM getiren metod.
        /// </summary>
        /// <param name="id">Ilan ID</param>
        /// <returns></returns>
        public IlanVM GetIlanVMByAracID(int id)
        {
            IlanRepository ilanRepository = new IlanRepository(ThisContext);

            return new IlanMapping()
                .IlanToIlanVM(ilanRepository
                .GetAll(x => x.AracID == id)
                .FirstOrDefault());
        }
    }
}
