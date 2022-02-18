namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleArac")]
    public partial class IhaleArac : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IhaleArac()
        {
            AracTeklif = new HashSet<AracTeklif>();
        }

        public int IhaleAracID { get; set; }

        public int IhaleID { get; set; }

        public int AracID { get; set; }

        [Column(TypeName = "money")]
        public decimal IhaleBaslangicFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal MinAlimFiyati { get; set; }

        public virtual Arac Arac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracTeklif> AracTeklif { get; set; }

        public virtual Ihale Ihale { get; set; }
    }
}
