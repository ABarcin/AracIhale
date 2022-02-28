using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.CORE.VM
{
    public class FavoriAramaKriterVM : BaseVM
    {
        public int FavoriAramaKriterID { get; set; }

        public int? MarkaID { get; set; }

        public int? ModelID { get; set; }

        public DateTime? BaslangicYil { get; set; }

        public DateTime? BitisYil { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaslangicFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal? BitisFiyat { get; set; }

        public int? BaslangicKM { get; set; }

        public int? BitisKM { get; set; }
    }
}
