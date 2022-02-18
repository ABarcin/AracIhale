using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class AracTeklifVM : BaseVM
    {
        public int AracTeklifID { get; set; }

        public int IhaleAracID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifFiyat { get; set; }

        public DateTime? Tarih { get; set; }
    }
}
