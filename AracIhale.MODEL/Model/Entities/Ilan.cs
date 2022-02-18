namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ilan")]
    public partial class Ilan : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ilan()
        {
            FavoriIlan = new HashSet<FavoriIlan>();
        }

        public int IlanID { get; set; }

        public int AracID { get; set; }

        [Required]
        public string Baslik { get; set; }

        [Required]
        public string Aciklama { get; set; }

        public virtual Arac Arac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriIlan> FavoriIlan { get; set; }
    }
}
