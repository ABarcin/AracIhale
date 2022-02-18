using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class KullaniciTipVM : BaseVM
    {
        public int KullaniciTipID { get; set; }

        [Required]
        [StringLength(50)]
        public string Tip { get; set; }

        public override string ToString()
        {
            return this.Tip;
        }
    }
}
