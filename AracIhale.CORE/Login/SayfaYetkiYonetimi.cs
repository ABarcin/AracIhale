using AracIhale.CORE.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.Login
{
    public class SayfaYetkiYonetimi
    {
        public SayfaVM Sayfa { get; set; }

        public List<YetkiVM> YetkiListesi { get; set; }
    }
}
