using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface ICalisanIletisimRepository : IRepository<CalisanIletisim>
    {
        string GetEmailByUserName(string kullaniciAd);
    }
}
