using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Model.Entities
{
    public partial class Log : BaseEntity
    {
        [Key]
        public int LogID { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string LogDetay { get; set; }
    }
}
