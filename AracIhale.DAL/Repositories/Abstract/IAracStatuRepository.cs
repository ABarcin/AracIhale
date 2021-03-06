using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracStatuRepository : IRepository<AracStatu>
    {
        List<StatuVM> StatuleriListele();
        void AracStatuEkle(AracStatuVM aracStatuVM);
        AracStatuVM AracinGuncelStatusunuGetir(int id);
        List<AracStatuVM> AracinStatuTarihcesiniGetir(int id);
    }
}
