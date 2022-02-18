namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracTramerDetay")]
    public partial class AracTramerDetay : BaseEntity
    {
        public int AracTramerDetayID { get; set; }

        public int AracParcaID { get; set; }

        public int AracTramerID { get; set; }

        public int TramerDetayID { get; set; }

        public virtual AracParca AracParca { get; set; }

        public virtual AracTramer AracTramer { get; set; }

        public virtual TramerDetay TramerDetay { get; set; }
    }
}
