using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Login
{
    public static class Login
    {
        public static CalisanVM GirisYapmisCalisan { get; set; }

        public static KullaniciVM GirisYapmisKullanici { get; set; }

        public static List<SayfaYetkiYonetimi> SayfaYetkiYonetimiListesi { get; set; }
    }
}
