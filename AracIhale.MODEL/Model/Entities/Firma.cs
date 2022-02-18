namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Firma")]
    public partial class Firma : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Firma()
        {
            FirmaIletisim = new HashSet<FirmaIletisim>();
            KurumsalKullanici = new HashSet<KurumsalKullanici>();
            Stok = new HashSet<Stok>();
        }

        public int FirmaID { get; set; }

        public string Unvan { get; set; }

        public int? SehirIlceID { get; set; }

        public int? FirmaTipID { get; set; }

        public int? PaketID { get; set; }

        public virtual FirmaTip FirmaTip { get; set; }

        public virtual Paket Paket { get; set; }

        public virtual SehirIlce SehirIlce { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FirmaIletisim> FirmaIletisim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KurumsalKullanici> KurumsalKullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stok> Stok { get; set; }
    }
}
