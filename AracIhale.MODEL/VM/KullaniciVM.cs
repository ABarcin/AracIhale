using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class KullaniciVM : BaseVM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // <-----
        public int KullaniciID { get; set; }

        [StringLength(50)]
        public string KullaniciAd { get; set; }
        //kullanıcı adı nvarchar fatih düzeltecek

        public int KullaniciTipID { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        public int RolID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        public bool? KVKK { get; set; }
    }
}
