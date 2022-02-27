﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Model.Entities
{
    public partial class Log 
    {
        [Key]
        public int LogID { get; set; }
        public DateTime LogTarih { get; set; }
        public string Kullanici { get; set; }
        public string Sayfa { get; set; }
        public string Islem { get; set; }
        public string LogMesaj { get; set; }

    }
}
