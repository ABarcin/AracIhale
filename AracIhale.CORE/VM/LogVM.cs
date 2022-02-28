using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class LogVM : BaseVM
    {
        [Key]
        public int LogID { get; set; }

        [Required]
        public string LogDetay { get; set; }

        public override string ToString()
        {
            return LogID.ToString() + CreatedDate.ToString();
        }

    }
}
