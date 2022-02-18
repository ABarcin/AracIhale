using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class AracTramerVM : BaseVM
    {
        public int AracTramerID { get; set; }

        public int AracID { get; set; }

        [Column(TypeName = "money")]
        public decimal Fiyat { get; set; }
    }
}
