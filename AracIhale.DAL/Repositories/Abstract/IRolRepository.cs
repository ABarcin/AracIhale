using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IRolRepository : IRepository<Rol>
    {
        List<RolVM> TumRoller();

        int RolIDGetir(string rolAd);
    }
}
