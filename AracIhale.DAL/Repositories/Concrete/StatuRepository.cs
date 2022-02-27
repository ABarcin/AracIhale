using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class StatuRepository : Repository<Statu>, IStatuRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public StatuRepository(AracIhaleEntities context) : base(context)
        {
            
        }
        public int HemenAlSatisStatuIDGetir()
        {
            return ThisContext.Statu.FirstOrDefault(x => x.StatuAd == "Hemen Al Satış").StatuID;
        }
    }
}
