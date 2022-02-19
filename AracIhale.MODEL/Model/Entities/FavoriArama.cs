namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FavoriArama")]
    public partial class FavoriArama : BaseEntity
    {
        public int FavoriAramaID { get; set; }

        public int FavoriAramaKriterID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        [Required]
        public string Ad { get; set; }

        public virtual FavoriAramaKriter FavoriAramaKriter { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
