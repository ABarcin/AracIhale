namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ihale")]
    public partial class Ihale : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ihale()
        {
            IhaleArac = new HashSet<IhaleArac>();
            IhaleSurec = new HashSet<IhaleSurec>();
            KurumsalIhale = new HashSet<KurumsalIhale>();
        }

        public int IhaleID { get; set; }

        [Required]
        public string IhaleAdi { get; set; }

        public int CalisanID { get; set; }

        public int KullaniciTipID { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBaslangic { get; set; }

        [Column(TypeName = "date")]
        public DateTime IhaleBitis { get; set; }

        public TimeSpan BaslangicSaat { get; set; }

        public TimeSpan BitisSaat { get; set; }

        public virtual Calisan Calisan { get; set; }

        public virtual KullaniciTip KullaniciTip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleArac> IhaleArac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleSurec> IhaleSurec { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KurumsalIhale> KurumsalIhale { get; set; }
    }
}
