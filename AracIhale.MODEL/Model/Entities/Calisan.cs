namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Calisan")]
    public partial class Calisan : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calisan()
        {
            CalisanIletisim = new HashSet<CalisanIletisim>();
            Ihale = new HashSet<Ihale>();
        }
        [Key]
        public int CalisanID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string KullaniciAd { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        public int RolID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        public bool? AktiflikDurumu { get; set; }

        public virtual Rol Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalisanIletisim> CalisanIletisim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ihale> Ihale { get; set; }
    }
}
