namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FavoriIlan")]
    public partial class FavoriIlan : BaseEntity
    {
        public int FavoriIlanID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        public int IlanID { get; set; }

        public DateTime Tarih { get; set; }

        public virtual Ilan Ilan { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
