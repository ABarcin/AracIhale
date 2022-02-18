using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IhaleVM : BaseVM 
    {
        public int IhaleID { get; set; }

        [Required]
        public string IhaleAdi { get; set; }

        public int CalisanID { get; set; }

        public int KullaniciTipID { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBaslangic { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBitis { get; set; }

        public TimeSpan BaslangicSaat { get; set; }

        public TimeSpan BitisSaat { get; set; }
    }

}
