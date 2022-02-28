using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IKurumsalKullaniciRepository : IRepository<KurumsalKullanici>
    {
        void KurumsalKullaniciEkle(KurumsalKullaniciVM kurumsalKullaniciVM);
        List<KurumsalKullaniciVM> KurumsalKullanicilariGetir();
        void KurumsalKullaniciGuncelle(KurumsalKullaniciVM kurumsalKullanici);
        KurumsalKullaniciVM KurumsalKullaniciGetir(object id);
    }
}
