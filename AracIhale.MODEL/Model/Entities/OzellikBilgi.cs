namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OzellikBilgi")]
    public partial class OzellikBilgi : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OzellikBilgi()
        {
            AracOzellik = new HashSet<AracOzellik>();
            FavoriOzellik = new HashSet<FavoriOzellik>();
        }

        public int OzellikBilgiID { get; set; }

        [Required]
        public string OzellikDetay { get; set; }

        public int OzellikID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracOzellik> AracOzellik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriOzellik> FavoriOzellik { get; set; }

        public virtual Ozellik Ozellik { get; set; }
    }
}
