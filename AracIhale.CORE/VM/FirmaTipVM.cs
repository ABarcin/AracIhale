using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class FirmaTipVM : BaseVM 
    {
        public int FirmaTipID { get; set; }

        public string FirmaTur { get; set; }

        public override string ToString()
        {
            return FirmaTur.ToString();
        }
    }
}
