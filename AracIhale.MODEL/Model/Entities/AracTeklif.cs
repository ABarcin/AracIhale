namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracTeklif")]
    public partial class AracTeklif : BaseEntity
    {
        public int AracTeklifID { get; set; }

        [Required]
        public int IhaleAracID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        [Column(TypeName = "money")]
        public decimal TeklifFiyat { get; set; }

        public DateTime? Tarih { get; set; }

        public bool? TeklifOnay { get; set; } = false;

        public virtual IhaleArac IhaleArac { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
