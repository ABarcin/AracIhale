using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IhaleAracVM : BaseVM
    {
        public int IhaleAracID { get; set; }

        public int IhaleID { get; set; }

        public int AracID { get; set; }

        [Column(TypeName = "money")]
        public decimal IhaleBaslangicFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal MinAlimFiyati { get; set; }
    }
}
