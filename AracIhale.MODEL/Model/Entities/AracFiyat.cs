namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracFiyat")]
    public partial class AracFiyat : BaseEntity
    {
        public int AracFiyatID { get; set; }

        public int AracID { get; set; }

        [Column(TypeName = "money")]
        public decimal Fiyat { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual Arac Arac { get; set; }
    }
}
