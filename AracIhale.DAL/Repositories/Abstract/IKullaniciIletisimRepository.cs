using AracIhale.MODEL.Model.Entities;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IKullaniciIletisimRepository : IRepository<KullaniciIletisim>
    {
        string GetEmailByUserName(string kullaniciAd);
    }
}
