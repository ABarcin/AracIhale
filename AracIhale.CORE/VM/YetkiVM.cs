using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class YetkiVM : BaseVM 
    {
        public int YetkiID { get; set; }

        [Required]
        public string YetkiAciklama { get; set; }
    }
}
