using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class StatuVM : BaseVM
    {
        public int StatuID { get; set; }

        [Required]
        public string StatuAd { get; set; }
        public override string ToString()
        {
            return StatuAd;
        }
    }
}
