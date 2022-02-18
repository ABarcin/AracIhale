using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class EkspertizVM : BaseVM
    {
        [Key]
        [Column(Order = 0)]
        public int EkspertizID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Ad { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Adres { get; set; }
    }
}
