﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class FirmaVM : BaseVM
    {
        public int FirmaID { get; set; }

        public string Unvan { get; set; }

        public int? SehirIlceID { get; set; }

        public int? FirmaTipID { get; set; }

        public int? PaketID { get; set; }
    }
}