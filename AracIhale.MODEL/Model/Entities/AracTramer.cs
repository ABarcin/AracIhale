namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracTramer")]
    public partial class AracTramer : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AracTramer()
        {
            AracTramerDetay = new HashSet<AracTramerDetay>();
        }

        public int AracTramerID { get; set; }

        public int AracID { get; set; }

        [Column(TypeName = "money")]
        public decimal Fiyat { get; set; }

        public virtual Arac Arac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracTramerDetay> AracTramerDetay { get; set; }
    }
}
