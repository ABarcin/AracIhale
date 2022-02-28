using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class FotografVM : BaseVM
    {
        public int FotografID { get; set; }

        [Required]
        public string FotoPath { get; set; }

        public int AracID { get; set; }
    }
}
