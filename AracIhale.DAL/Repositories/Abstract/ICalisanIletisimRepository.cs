using AracIhale.MODEL.Model.Entities;
using AracIhale.CORE.VM;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface ICalisanIletisimRepository : IRepository<CalisanIletisim>
    {
        string GetEmailByUserName(string kullaniciAd);
        List<CalisanIletisimVM> IletisimBilgileriniGetir(CalisanVM calisan);
        void IletisimBilgisiEkle(CalisanIletisimVM vm);
        void IletisimBilgisiGuncelle(CalisanIletisimVM vm);
    }
}
