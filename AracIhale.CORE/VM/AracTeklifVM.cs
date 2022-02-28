using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class AracTeklifVM : BaseVM
    {
        public int AracTeklifID { get; set; }

        [Required]
        public int IhaleAracID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifFiyat { get; set; }

        public DateTime? Tarih { get; set; }
    }
}
