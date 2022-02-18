using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class AracCDListVM : BaseVM
    {
        public int AracID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        public int MarkaID { get; set; }

        public int ModelID { get; set; }

        public int Km { get; set; }

        public DateTime Yıl { get; set; }

        public virtual ArabaModel ArabaModel { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Marka Marka { get; set; }
    }
}
