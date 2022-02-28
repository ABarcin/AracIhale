using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IAracFiyatRepository : IRepository<AracFiyat>
    {
        void AracFiyatEkle(AracFiyatVM aracFiyatVM);
        AracFiyatVM AracinGuncelFiyatiniGetir(int id);
    }
}
