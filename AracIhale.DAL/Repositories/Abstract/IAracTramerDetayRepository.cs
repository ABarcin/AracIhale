using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracTramerDetayRepository : IRepository<AracTramerDetay>
    {
        void AracTramerDetayEkle(AracTramerDetayVM aracTramerDetayVM);

        void AracTramerDetayGuncelle(AracTramerDetayVM aracTramerDetayVM);

        AracTramerDetayVM AracTramerDetayVMGetir(int aracTramerID, int aracParcaID);

        List<AracTramerDetayVM> AracTramerVMListesiniGetir(int aracTramerID);
    }
}
