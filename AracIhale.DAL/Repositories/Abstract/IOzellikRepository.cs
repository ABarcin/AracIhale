using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Abstract
{
    public interface IOzellikRepository : IRepository<Ozellik> 
    {
        List<OzellikBilgiVM> GovdeTipiListele();
        List<OzellikBilgiVM> YakitTipiListele();
        List<OzellikBilgiVM> VitesTipiListele();
        List<OzellikBilgiVM> VersiyonListele();
        List<OzellikBilgiVM> RenkListele();
        List<OzellikBilgiVM> DonanimListele();
    }
}
