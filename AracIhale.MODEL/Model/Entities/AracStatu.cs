namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracStatu")]
    public partial class AracStatu : BaseEntity
    {
        public int AracStatuID { get; set; }

        public int AracID { get; set; }

        public int StatuID { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Statu Statu { get; set; }
    }
}
