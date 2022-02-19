using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class KullaniciIletisimVM : BaseVM
    {
        public int KullaniciIletisimID { get; set; }

        public int IletisimTuruID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        [Required]
        public string IletisimBilgi { get; set; }
    }
}
