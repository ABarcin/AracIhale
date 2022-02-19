namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Arac = new HashSet<Arac>();
            AracTeklif = new HashSet<AracTeklif>();
            FavoriArama = new HashSet<FavoriArama>();
            FavoriIlan = new HashSet<FavoriIlan>();
            KullaniciIletisim = new HashSet<KullaniciIletisim>();
            KurumsalKullanici = new HashSet<KurumsalKullanici>();
        }

        [Key]
        public int KullaniciID { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string KullaniciAd { get; set; }

        public int KullaniciTipID { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        public int RolID { get; set; }

        [Required]
        public string Ad { get; set; }

        [Required]
        public string Soyad { get; set; }

        public bool? KVKK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracTeklif> AracTeklif { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriArama> FavoriArama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriIlan> FavoriIlan { get; set; }

        public virtual KullaniciTip KullaniciTip { get; set; }

        public virtual Rol Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciIletisim> KullaniciIletisim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KurumsalKullanici> KurumsalKullanici { get; set; }
    }
}
