using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class AracVM:BaseVM
    {
        public int AracID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        public int MarkaID { get; set; }

        public int ModelID { get; set; }

        public int Km { get; set; }

        public int Yil { get; set; }
    }
}
