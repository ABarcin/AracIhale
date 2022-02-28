using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class SehirVM : BaseVM
    {
        public int SehirID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }
    }
}
