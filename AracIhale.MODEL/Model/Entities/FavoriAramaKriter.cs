namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FavoriAramaKriter")]
    public partial class FavoriAramaKriter : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FavoriAramaKriter()
        {
            FavoriArama = new HashSet<FavoriArama>();
            FavoriOzellik = new HashSet<FavoriOzellik>();
        }

        public int FavoriAramaKriterID { get; set; }

        public int? MarkaID { get; set; }

        public int? ModelID { get; set; }

        public DateTime? BaslangicYil { get; set; }

        public DateTime? BitisYil { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaslangicFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal? BitisFiyat { get; set; }

        public int? BaslangicKM { get; set; }

        public int? BitisKM { get; set; }

        public virtual ArabaModel ArabaModel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriArama> FavoriArama { get; set; }

        public virtual Marka Marka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FavoriOzellik> FavoriOzellik { get; set; }
    }
}
