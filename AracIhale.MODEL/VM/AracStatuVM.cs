using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class AracStatuVM : BaseVM
    {
        public int AracStatuID { get; set; }

        public int AracID { get; set; }

        public int StatuID { get; set; }

        public DateTime? Tarih { get; set; }
    }
}
