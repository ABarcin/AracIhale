using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface ICalisanRepository : IRepository<Calisan>
    {
        bool OturumAc(string kullaniciAdi, string sifre);
        List<CalisanVM> TumCalisanlar();
        void Guncelle(CalisanVM calisan);
        CalisanVM KullaniciGetir(object id);
        CalisanVM KullaniciGetir(string kullaniciAdi);
        void Ekle(CalisanVM calisan);
        void Sil(object id);

    }
}
