using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System.Linq;

namespace AracIhale.DAL.Repositories.Concrete
{
    public class KullaniciIletisimRepository : Repository<KullaniciIletisim>, IKullaniciIletisimRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public KullaniciIletisimRepository(AracIhaleEntities context) : base(context)
        {
        }
        public string GetEmailByUserName(string kullaniciAd)
        {
            Kullanici kullanici = new KullaniciRepository(new AracIhaleEntities()).GetAll(y => y.KullaniciAd == kullaniciAd).FirstOrDefault();
            KullaniciIletisimVM vM = null;
            int id = kullanici == null ? 0 : kullanici.KullaniciID;
            if (id != 0)
            {
                KullaniciIletisim kullaniciIletisim = this.GetAll(x => x.Kullanici.KullaniciID == id).FirstOrDefault();
                vM = new KullaniciIletisimMapping().KullaniciIletisimToKullaniciIletisimVM(kullaniciIletisim);
            }
            return vM == null ? null : vM.IletisimBilgi;
        }
    }
}
