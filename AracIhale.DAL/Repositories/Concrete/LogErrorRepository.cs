using AracIhale.CORE.Login;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class LogErrorRepository : Repository<LogError>, ILogErrorRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public LogErrorRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AddLog(string sayfaAd ,string islem,string exception)
        {
            if (Login.GirisYapmisCalisan != null)
            {
                LogError log = new LogError() { Kullanici = Login.GirisYapmisCalisan.KullaniciAd, Islem = islem, LogMesaj = "Başarısız", LogTarih = DateTime.Now, Sayfa = sayfaAd, Hata=exception };
                Add(log);
            }
            else
            {
                LogError log = new LogError() { Kullanici = Login.GirisYapmisKullanici.KullaniciAd, Islem = islem, LogMesaj = "Başarısız", LogTarih = DateTime.Now, Sayfa = sayfaAd,Hata=exception };
                Add(log);
            }

        }
    }
}
