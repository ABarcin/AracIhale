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
    public class YetkiRepository : Repository<Yetki>, IYetkiRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public YetkiRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<YetkiVM> TumYetkiler()
        {
            return new YetkiMapping().ListYetkiToListYetkiVM(this.GetAll().ToList());
        }
    }
}
