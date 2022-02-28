using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class AracParcaVM : BaseVM
    {
        public int AracParcaID { get; set; }

        [Required]
        public string ParcaAd { get; set; }
    }
}