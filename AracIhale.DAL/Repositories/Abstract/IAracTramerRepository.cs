using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracTramerRepository : IRepository<AracTramer>
    {
        int EklenenAracTramerIDGetir();

        int AracTramerEkle(AracTramerVM aracTramerVM);

        void AracTramerGuncelle(AracTramerVM aracTramerVM);

        AracTramerVM AracTramerVMGetir(int aracID);

        AracTramerVM GetAracTramerVMByAracID(int id);
    }
}
