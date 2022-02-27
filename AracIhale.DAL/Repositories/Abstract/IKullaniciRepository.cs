using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IKullaniciRepository : IRepository<Kullanici>
    {
        void BireyselKullaniciEkle(KullaniciVM kullaniciVM);
        KullaniciVM KullaniciGetir(string kullaniciAdi);
        KullaniciVM KullaniciGetir(object id);
        bool OturumAc(string kullaniciAdi, string sifre);
        KullaniciVM AracKullanicisiniGetir(int aracID);
    }
}
