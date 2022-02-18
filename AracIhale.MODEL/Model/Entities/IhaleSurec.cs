namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleSurec")]
    public partial class IhaleSurec : BaseEntity
    {
        [Key]
        public int StatuIhaleID { get; set; }

        public int IhaleID { get; set; }

        public int IhaleStatuID { get; set; }

        public DateTime? Tarih { get; set; }

        public virtual Ihale Ihale { get; set; }

        public virtual IhaleStatu IhaleStatu { get; set; }
    }
}
