using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IhaleStatuVM : BaseVM
    {
        public int IhaleStatuID { get; set; }

        [Required]
        public string Durum { get; set; }

        public override string ToString()
        {
            return this.Durum;
        }
    }
}
