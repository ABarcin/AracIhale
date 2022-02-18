using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class KurumsalKullaniciVM : BaseVM
    {
        public int KurumsalKullaniciID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        public int FirmaID { get; set; }

        public bool? OnayDurum { get; set; }
    }
}
