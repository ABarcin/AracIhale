using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public abstract class BaseVM
    {
        public bool? IsActive { get; set; } = true;

        public DateTime? ModifiedDate { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string ModifiedBy { get; set; }
    }
}
