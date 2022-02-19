namespace AracIhale.MODEL.Model.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciIletisim")]
    public partial class KullaniciIletisim : BaseEntity
    {
        public int KullaniciIletisimID { get; set; }

        public int IletisimTuruID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        [Required]
        public string IletisimBilgi { get; set; }

        public virtual IletisimTur IletisimTur { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
