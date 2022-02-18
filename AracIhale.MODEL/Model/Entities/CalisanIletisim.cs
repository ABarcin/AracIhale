namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CalisanIletisim")]
    public partial class CalisanIletisim : BaseEntity
    {
        public int CalisanIletisimID { get; set; }

        public int IletisimTuruID { get; set; }

        public int CalisanID { get; set; }

        [Required]
        public string IletisimBilgi { get; set; }

        public virtual Calisan Calisan { get; set; }

        public virtual IletisimTur IletisimTur { get; set; }
    }
}
