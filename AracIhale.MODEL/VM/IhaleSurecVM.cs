using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IhaleSurecVM : BaseVM
    {
        [Key]
        public int StatuIhaleID { get; set; }

        public int IhaleID { get; set; }

        public int IhaleStatuID { get; set; }

        public DateTime? Tarih { get; set; }
    }
}
