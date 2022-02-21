using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IletisimTurVM : BaseVM
    {
        public int IletisimTuruID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
