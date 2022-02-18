namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolYetki")]
    public partial class RolYetki : BaseEntity
    {
        public int RolYetkiID { get; set; }

        public int RolID { get; set; }

        public int YetkiID { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual Yetki Yetki { get; set; }
    }
}
