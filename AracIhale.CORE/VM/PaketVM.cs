using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class PaketVM : BaseVM
    {
        public int PaketID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        public int AracLimiti { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
