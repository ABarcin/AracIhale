using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class FirmaIletisimVM : BaseVM
    {
        public int FirmaIletisimID { get; set; }

        public int IletisimTuruID { get; set; }

        public int FirmaID { get; set; }

        [Required]
        public string IletisimBilgi { get; set; }
    }
}
