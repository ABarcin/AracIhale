namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KurumsalIhale")]
    public partial class KurumsalIhale : BaseEntity
    {
        public int KurumsalIhaleID { get; set; }

        public int IhaleID { get; set; }

        public int FirmaID { get; set; }

        public virtual Ihale Ihale { get; set; }
    }
}
