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
    public class AracTramerRepository : Repository<AracTramer>, IAracTramerRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public AracTramerRepository(AracIhaleEntities context) : base(context)
        {

        }

        /// <summary>
        /// Arac ID'sine gore AracTramerVM getiren metod.
        /// </summary>
        /// <param name="id">Arac ID</param>
        public AracTramerVM GetAracTramerVMByAracID(int id)
        {
            AracTramerRepository aracTramerRepository = new AracTramerRepository(ThisContext);

            return new AracTramerMapping()
                .AracTramerToAracTramerVM(aracTramerRepository
                .GetAll(x => x.AracID == id)
                .FirstOrDefault());
        }
    }
}
