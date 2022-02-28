using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class YetkiRepository : Repository<Yetki>, IYetkiRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public YetkiRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<YetkiVM> TumYetkiler()
        {
            return new YetkiMapping().ListYetkiToListYetkiVM(GetAll().ToList());
        }
    }
}
