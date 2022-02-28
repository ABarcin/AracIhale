using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class FavoriIlanVM : BaseVM
    {
        public int FavoriIlanID { get; set; }

        [Required]
        public int KullaniciID { get; set; }

        public int IlanID { get; set; }

        public DateTime Tarih { get; set; }
    }
}
