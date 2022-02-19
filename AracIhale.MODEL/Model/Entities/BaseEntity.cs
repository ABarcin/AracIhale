using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.Model.Entities
{
    public abstract class BaseEntity
    {
        public bool? IsActive { get; set; } = true;

        public DateTime? ModifiedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
