using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class OzellikVM : BaseVM 
    {
        public int OzellikID { get; set; }

        [Required]
        public string OzellikAd { get; set; }

        public override string ToString()
        {
            return OzellikAd;
        }
    }
}
