using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public abstract class BaseVM
    {
        public bool? IsActive { get; set; } = true;

        public DateTime? ModifiedDate { get; set; } = DateTime.Now;

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public int? ModifiedBy { get; set; }
    }
}
