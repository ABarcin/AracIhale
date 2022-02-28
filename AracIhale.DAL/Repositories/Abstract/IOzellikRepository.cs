using AracIhale.CORE.VM;
using AracIhale.MODEL.Model.Entities;
using System.Collections.Generic;

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
