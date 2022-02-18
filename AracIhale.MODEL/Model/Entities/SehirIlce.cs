namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SehirIlce")]
    public partial class SehirIlce : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SehirIlce()
        {
            Firma = new HashSet<Firma>();
        }

        public int SehirIlceID { get; set; }

        public int SehirID { get; set; }

        public int IlceID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Firma> Firma { get; set; }

        public virtual Ilce Ilce { get; set; }

        public virtual Sehir Sehir { get; set; }
    }
}
