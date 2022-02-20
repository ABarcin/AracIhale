using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IhaleListVM : BaseVM
    {
        public int IhaleID { get; set; }

        [Required]
        public string IhaleAdi { get; set; }

        public int KullaniciTipID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciTip { get; set; }

        [StringLength(50)]
        [Column(TypeName = "date")]
        public DateTime IhaleBaslangic { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBitis { get; set; }

        public int IhaleStatuID { get; set; }

        [Required]
        public string IhaleDurum { get; set; }
        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }
    }
}
