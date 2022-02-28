using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class CalisanVM : BaseVM
    {
        public int CalisanID { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAd { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(50)]
        public string RolAd { get; set; }
        public int RolID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        public bool? AktiflikDurumu { get; set; }
    }
}
