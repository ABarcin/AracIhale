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
