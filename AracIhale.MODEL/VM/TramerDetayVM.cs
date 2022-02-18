using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class TramerDetayVM : BaseVM
    {
        public int TramerDetayID { get; set; }

        [Required]
        public string TramerDurum { get; set; }
    }
}
