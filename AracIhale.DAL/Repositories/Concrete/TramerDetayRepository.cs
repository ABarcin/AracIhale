using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class TramerDetayRepository : Repository<TramerDetay>, ITramerDetayRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public TramerDetayRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<TramerDetayVM> TramerDurumListesiGetir()
        {
            TramerDetayRepository tramerDetayRepository = new TramerDetayRepository(ThisContext);

            TramerDetayMapping tramerDetayMapping = new TramerDetayMapping();

            return tramerDetayMapping.ListTramerDetayToListTramerDetayVM(tramerDetayRepository.GetAll());
        }
    }
}
