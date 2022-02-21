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
    public class CalisanIletisimRepository : Repository<CalisanIletisim>, ICalisanIletisimRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public CalisanIletisimRepository(AracIhaleEntities context) : base(context)
        {

        }
        CalisanIletisimMapping mapping = new CalisanIletisimMapping();
        CalisanRepository calisanRepo=new CalisanRepository(new AracIhaleEntities());
        public string GetEmailByUserName(string kullaniciAd)
        {
            Calisan calisan= calisanRepo.GetAll(y => y.KullaniciAd == kullaniciAd).FirstOrDefault();
            CalisanIletisimVM vM=null;
            int id = calisan == null ? 0 : calisan.CalisanID;
            if (id!=0)
            {
                CalisanIletisim calisanIletisim = this.GetAll(x => x.Calisan.CalisanID == id).FirstOrDefault();
                vM = mapping.CalisanIletisimToCalisanIletisimVM(calisanIletisim);
            }
            return vM == null ? null : vM.IletisimBilgi;
        }

        public List<CalisanIletisimVM> IletisimBilgileriniGetir(CalisanVM calisan)
        {
            return mapping.ListCalisanIletisimToListCalisanIletisimVM( this.GetAll(x => x.IsActive == true && x.CalisanID == calisan.CalisanID).ToList());
        }

        public void IletisimBilgisiEkle(CalisanIletisimVM vm)
        {
            this.Add(mapping.CalisanIletisimVMToCalisanIletisim(vm));
        }

    }
}
