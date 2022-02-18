namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KurumsalKullanici")]
    public partial class KurumsalKullanici : BaseEntity
    {
        public int KurumsalKullaniciID { get; set; }

        [Required]
        [StringLength(25)]
        public string KullaniciAd { get; set; }

        public int FirmaID { get; set; }

        public bool? OnayDurum { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
