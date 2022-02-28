using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        void BireyselKullaniciEkle(KullaniciVM kullaniciVM);
        KullaniciVM KullaniciGetir(string kullaniciAdi);
        KullaniciVM KullaniciGetir(object id);
        bool OturumAc(string kullaniciAdi, string sifre);
        KullaniciVM AracKullanicisiniGetir(int aracID);
        List<KullaniciVM> TumKullanicilariGetir();
    }
}
