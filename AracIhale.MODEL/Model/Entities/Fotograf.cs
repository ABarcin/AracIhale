namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Fotograf")]
    public partial class Fotograf : BaseEntity
    {
        public int FotografID { get; set; }

        [Required]
        public string FotoPath { get; set; }

        public int AracID { get; set; }

        public virtual Arac Arac { get; set; }
    }
}
