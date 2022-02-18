using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class FavoriAramaVM : BaseVM
    {
        public int FavoriAramaID { get; set; }

        public int FavoriAramaKriterID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        [Required]
        public string Ad { get; set; }

    }
}
