﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class FavoriIlanVM : BaseVM
    {
        public int FavoriIlanID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        public int IlanID { get; set; }

        public DateTime Tarih { get; set; }
    }
}
