namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Stok")]
    public partial class Stok : BaseEntity
    {
        public int StokID { get; set; }

        public int FirmaID { get; set; }

        public int? StokAdeti { get; set; }

        public virtual Firma Firma { get; set; }
    }
}
