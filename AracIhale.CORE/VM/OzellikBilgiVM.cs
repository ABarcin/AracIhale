using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class OzellikBilgiVM : BaseVM 
    {
        public int OzellikBilgiID { get; set; }

        [Required]
        public string OzellikDetay { get; set; }

        public int OzellikID { get; set; }

        public override string ToString()
        {
            return OzellikDetay;
        }
    }
}
