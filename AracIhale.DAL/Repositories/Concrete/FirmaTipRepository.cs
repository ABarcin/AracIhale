using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class FirmaTipRepository : Repository<FirmaTip>, IFirmaTipRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public FirmaTipRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<FirmaTipVM> GetFirmaTip()
        {
            List<FirmaTipVM> firmaTipleri = ThisContext.FirmaTip.Select(x => new FirmaTipVM()
            {
                FirmaTur = x.FirmaTur,
                IsActive = x.IsActive
            }).Where(x => x.IsActive == true).ToList();
            return firmaTipleri;
        }
    }
}
