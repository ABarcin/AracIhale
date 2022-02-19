using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Model.Entities
{
    [Table("Sayfa")]
    public partial class Sayfa : BaseEntity
    {
        public Sayfa()
        {
            RolYetki = new HashSet<RolYetki>();
        }
        [Key]
        public int SayfaID { get; set; }

        [Required]
        public string SayfaAdi { get; set; }

        public virtual ICollection<RolYetki> RolYetki { get; set; }
    }
}
