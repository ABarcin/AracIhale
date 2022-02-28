using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class IlanVM : BaseVM
    {
        public int IlanID { get; set; }

        public int AracID { get; set; }

        [Required]
        public string Baslik { get; set; }

        [Required]
        public string Aciklama { get; set; }
    }
}
