using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IMarkaRepository : IRepository<Marka> 
    {
        List<MarkaVM> TumMarkalar();
    }
}
