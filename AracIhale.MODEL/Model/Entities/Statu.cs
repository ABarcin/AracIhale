namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Statu")]
    public partial class Statu : BaseEntity
    {
        public Statu()
        {
            AracStatu = new HashSet<AracStatu>();
        }
        public int StatuID { get; set; }

        [Required]
        public string StatuAd { get; set; }

        public virtual ICollection<AracStatu> AracStatu { get; set; }
    }
}
