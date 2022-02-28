using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracOzellikRepository : IRepository<AracOzellik>
    {
        void AracOzellikEkle(List<AracOzellikVM> aracOzellikVMs);
        List<AracOzellikVM> AracOzellikleriniGetir(int id);
        void AracOzellikGuncelle(List<AracOzellikVM> aracOzellikVMs);
    }
}
