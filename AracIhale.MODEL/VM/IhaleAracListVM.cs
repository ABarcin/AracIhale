using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracIhale.MODEL.VM
{
    public class IhaleAracListVM : BaseVM
    {
        public int AracID { get; set; }
        public int IhaleAracID { get; set; }
        public string MarkaAd { get; set; }
        public string ModelAd { get; set; }
        public string StatuAd { get; set; }
        public int StatuID { get; set; }
        public string GovdeAd { get; set; }
        public string YakıtAd { get; set; }
        public string VitesAd { get; set; }
        public string Versiyon { get; set; }
        public string RenkAd { get; set; }
        public string DonanımAd { get; set; }
        public int Km { get; set; }
        public int Yil { get; set; }
    }
}
