namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FirmaIletisim")]
    public partial class FirmaIletisim : BaseEntity
    {
        public int FirmaIletisimID { get; set; }

        public int IletisimTuruID { get; set; }

        public int FirmaID { get; set; }

        [Required]
        public string IletisimBilgi { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual IletisimTur IletisimTur { get; set; }
    }
}
