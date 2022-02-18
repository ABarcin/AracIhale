namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracOzellik")]
    public partial class AracOzellik : BaseEntity
    {
        public int AracOzellikID { get; set; }

        public int AracID { get; set; }

        public int OzellikBilgiID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual OzellikBilgi OzellikBilgi { get; set; }
    }
}
