using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class SayfaVM : BaseVM
    {
        [Key]
        public int SayfaID { get; set; }

        [Required]
        [StringLength(50)]
        public string SayfaAdi { get; set; }

        public override string ToString()
        {
            return SayfaAdi; 
        }
    }
}
