using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracParcaRepository : IRepository<AracParca>
    {
        List<AracParcaVM> AracParcaListesiGetir();
    }
}
