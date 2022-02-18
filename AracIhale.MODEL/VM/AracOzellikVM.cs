using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class AracOzellikVM : BaseVM
    {
        public int AracOzellikID { get; set; }

        public int AracID { get; set; }

        public int OzellikBilgiID { get; set; }
    }
}
