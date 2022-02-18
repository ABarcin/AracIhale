using AracIhale.MODEL.Model.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracIhale.MODEL.VM
{
    public class AracFiyatVM:BaseVM
    {
        public int AracFiyatID { get; set; }

        public int AracID { get; set; }

        [Column(TypeName = "money")]
        public decimal Fiyat { get; set; }

        public DateTime? Tarih { get; set; }
    }
}
