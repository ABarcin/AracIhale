using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using System;
using System.Collections.Generic;

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

        public List<KurumsalKullaniciVM> KurumsalKullanicilariGetir()
        {
            return new KurumsalKullaniciMapping().ListKurumsalKullaniciToListKurumsalKullaniciVM(GetAll());
        }

        public void KurumsalKullaniciGuncelle(KurumsalKullaniciVM kurumsalKullanici)
        {
            KurumsalKullanici kurumsal = new KurumsalKullaniciMapping().KurumsalKullaniciVMToKurumsalKullanici(kurumsalKullanici);
            UpdateWithId(kurumsalKullanici.KurumsalKullaniciID, kurumsal);
        }

        public KurumsalKullaniciVM KurumsalKullaniciGetir(object id)
        {
            return new KurumsalKullaniciMapping().KurumsalKullaniciToKurumsalKullaniciVM(GetByID(id));
        }
    }
}
