using AracIhale.CORE.Login;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class LogRepository : Repository<Log>, ILogRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public LogRepository(AracIhaleEntities context) : base(context)
        {

        }

        public void AddLog(string sayfaAd,string islem)
        {
            if (Login.GirisYapmisCalisan != null)
            {
                Log log = new Log() { Kullanici = Login.GirisYapmisCalisan.KullaniciAd,Islem=islem, LogMesaj="Başarılı", LogTarih=DateTime.Now, Sayfa=sayfaAd};
                Add(log);
            }
            else 
            {
                Log log = new Log() { Kullanici = Login.GirisYapmisKullanici.KullaniciAd, Islem=islem,LogMesaj = "Başarılı", LogTarih = DateTime.Now, Sayfa = sayfaAd };
                Add(log);
            }
            
        }
    }
}
