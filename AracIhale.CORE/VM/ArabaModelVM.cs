using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class ArabaModelVM : BaseVM
    {
        [Key]
        public int ModelID { get; set; }

        public int MarkaID { get; set; }

        [Required]
        [StringLength(50)]
        public string Ad { get; set; }

        public int UstModelID { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
