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
    public class KurumsalKullaniciRepository : Repository<KurumsalKullanici>, IKurumsalKullaniciRepository
    {
        public AracIhaleEntities ThisContext { get { return _context as AracIhaleEntities; } }
        public KurumsalKullaniciRepository(AracIhaleEntities context) : base(context)
        {
            
        }

        public void KurumsalKullaniciEkle(KurumsalKullaniciVM kurumsalKullaniciVM)
        {
            KurumsalKullaniciRepository kurumsalKullaniciRepository = new KurumsalKullaniciRepository(ThisContext);

            KurumsalKullanici kurumsalKullanici = new KurumsalKullaniciMapping().KurumsalKullaniciVMToKurumsalKullanici(kurumsalKullaniciVM);

            kurumsalKullanici.CreatedDate = DateTime.Now;
            kurumsalKullanici.IsActive = true;

            kurumsalKullaniciRepository.Add(kurumsalKullanici);
        }
    }
}
