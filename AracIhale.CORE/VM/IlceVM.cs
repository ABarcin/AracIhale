using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class IlceVM :BaseVM
    {
        public int IlceID { get; set; }

        [Required]
        public string Ad { get; set; }
    }
}
