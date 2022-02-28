using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IIlanRepository : IRepository<Ilan>
    {
        IlanVM IlanVMGetir(int aracID);

        void IlanEkle(IlanVM ilanVM);

        void IlanGuncelle(IlanVM ilanVM);

        IlanVM GetIlanVMByAracID(int id);
    }
}
