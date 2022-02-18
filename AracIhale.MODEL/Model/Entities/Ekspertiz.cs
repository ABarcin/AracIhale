namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ekspertiz")]
    public partial class Ekspertiz : BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public int EkspertizID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Ad { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Adres { get; set; }
    }
}
