using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class OzellikRepository : Repository<Ozellik>, IOzellikRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public OzellikRepository(AracIhaleEntities context) : base(context)
        {

        }

        public List<OzellikBilgiVM> GovdeTipiListele()
        {
            var ozellikListesi = ThisContext.OzellikBilgi.Where(x => x.OzellikID == ThisContext.Ozellik.FirstOrDefault(y => y.OzellikAd == "Gövde Tipi").OzellikID).ToList();
            List<OzellikBilgiVM> ozellikVMler = new OzellikBilgiMapping().ListOzellikBilgiToListOzellikBilgiVM(ozellikListesi);
            return ozellikVMler;
        }

        public List<OzellikBilgiVM> YakitTipiListele()
        {
            var ozellikListesi = ThisContext.OzellikBilgi.Where(x => x.OzellikID == ThisContext.Ozellik.FirstOrDefault(y => y.OzellikAd == "Yakıt Tipi").OzellikID).ToList();
            List<OzellikBilgiVM> ozellikVMler = new OzellikBilgiMapping().ListOzellikBilgiToListOzellikBilgiVM(ozellikListesi);
            return ozellikVMler;
        }

        public List<OzellikBilgiVM> VitesTipiListele()
        {
            var ozellikListesi = ThisContext.OzellikBilgi.Where(x => x.OzellikID == ThisContext.Ozellik.FirstOrDefault(y => y.OzellikAd == "Vites Tipi").OzellikID).ToList();
            List<OzellikBilgiVM> ozellikVMler = new OzellikBilgiMapping().ListOzellikBilgiToListOzellikBilgiVM(ozellikListesi);
            return ozellikVMler;
        }

        public List<OzellikBilgiVM> VersiyonListele()
        {
            var ozellikListesi = ThisContext.OzellikBilgi.Where(x => x.OzellikID == ThisContext.Ozellik.FirstOrDefault(y => y.OzellikAd == "Versiyon").OzellikID).ToList();
            List<OzellikBilgiVM> ozellikVMler = new OzellikBilgiMapping().ListOzellikBilgiToListOzellikBilgiVM(ozellikListesi);
            return ozellikVMler;
        }

        public List<OzellikBilgiVM> RenkListele()
        {
            var ozellikListesi = ThisContext.OzellikBilgi.Where(x => x.OzellikID == ThisContext.Ozellik.FirstOrDefault(y => y.OzellikAd == "Renk").OzellikID).ToList();
            List<OzellikBilgiVM> ozellikVMler = new OzellikBilgiMapping().ListOzellikBilgiToListOzellikBilgiVM(ozellikListesi);
            return ozellikVMler;
        }

        public List<OzellikBilgiVM> DonanimListele()
        {
            var ozellikListesi = ThisContext.OzellikBilgi.Where(x => x.OzellikID == ThisContext.Ozellik.FirstOrDefault(y => y.OzellikAd == "Donanım").OzellikID).ToList();
            List<OzellikBilgiVM> ozellikVMler = new OzellikBilgiMapping().ListOzellikBilgiToListOzellikBilgiVM(ozellikListesi);
            return ozellikVMler;
        }
    }
}
