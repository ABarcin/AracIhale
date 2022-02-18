namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FavoriOzellik")]
    public partial class FavoriOzellik : BaseEntity
    {
        public int FavoriOzellikID { get; set; }

        public int OzellikBilgiID { get; set; }

        public int FavoriAramaKriterID { get; set; }

        public virtual FavoriAramaKriter FavoriAramaKriter { get; set; }

        public virtual OzellikBilgi OzellikBilgi { get; set; }
    }
}
