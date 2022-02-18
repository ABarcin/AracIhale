using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class FavoriOzellikVM : BaseVM
    {
        public int FavoriOzellikID { get; set; }

        public int OzellikBilgiID { get; set; }

        public int FavoriAramaKriterID { get; set; }
    }
}
