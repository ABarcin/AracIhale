using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface ITramerDetayRepository : IRepository<TramerDetay>
    {
        List<TramerDetayVM> TramerDurumListesiGetir();
    }
}
