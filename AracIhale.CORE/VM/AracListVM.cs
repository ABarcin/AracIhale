using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class AracListVM : BaseVM
    {
        public int AracID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciTip { get; set; }

        [Required]
        [StringLength(50)]
        public string MarkaAd { get; set; }

        [Required]
        [StringLength(50)]
        public string ModelAd { get; set; }

        public string StatuAd { get; set; }

        public int StatuID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        public string KullaniciAd { get; set; }

        public override string ToString()
        {
            return this.MarkaAd + " " + this.ModelAd;
        }
    }
}
