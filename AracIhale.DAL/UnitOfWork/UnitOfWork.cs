using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.DAL.Repositories.Concrete;
using AracIhale.MODEL.Model.Context;

namespace AracIhale.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AracIhaleEntities _unitOfWorkContext;

        public UnitOfWork(AracIhaleEntities UnitOfWorkContext)
        {
            _unitOfWorkContext = UnitOfWorkContext;
            AracFiyatRepository = new AracFiyatRepository(UnitOfWorkContext);
            AracOzellikRepository = new AracOzellikRepository(UnitOfWorkContext);
            AracParcaRepository = new AracParcaRepository(UnitOfWorkContext);
            AracRepository = new AracRepository(UnitOfWorkContext);
            AracStatuRepository = new AracStatuRepository(UnitOfWorkContext);
            AracTeklifRepository = new AracTeklifRepository(UnitOfWorkContext);
            AracTramerDetayRepository = new AracTramerDetayRepository(UnitOfWorkContext);
            AracTramerRepository = new AracTramerRepository(UnitOfWorkContext);
            CalisanIletisimRepository = new CalisanIletisimRepository(UnitOfWorkContext);
            CalisanRepository = new CalisanRepository(UnitOfWorkContext);
            FavoriAramaKriterRepository = new FavoriAramaKriterRepository(UnitOfWorkContext);
            FavoriAramaRepository = new FavoriAramaRepository(UnitOfWorkContext);
            FavoriIlanRepository = new FavoriIlanRepository(UnitOfWorkContext);
            FavoriOzellikRepository = new FavoriOzellikRepository(UnitOfWorkContext);
            FirmaIletisimRepository = new FirmaIletisimRepository(UnitOfWorkContext);
            FirmaRepository = new FirmaRepository(UnitOfWorkContext);
            FirmaTipRepository = new FirmaTipRepository(UnitOfWorkContext);
            FirmaTipRepository = new FirmaTipRepository(UnitOfWorkContext);
            IhaleAracRepository = new IhaleAracRepository(UnitOfWorkContext);
            IhaleRepository = new IhaleRepository(UnitOfWorkContext);
            IhaleStatuRepository = new IhaleStatuRepository(UnitOfWorkContext);
            IhaleSurecRepository = new IhaleSurecRepository(UnitOfWorkContext);
            IlanRepository = new IlanRepository(UnitOfWorkContext);
            IletisimTurRepository = new IletisimTurRepository(UnitOfWorkContext);
            KullaniciIletisimRepository = new KullaniciIletisimRepository(UnitOfWorkContext);
            KullaniciRepository = new KullaniciRepository(UnitOfWorkContext);
            KullaniciTipRepository = new KullaniciTipRepository(UnitOfWorkContext);
            KurumsalIhaleRepository = new KurumsalIhaleRepository(UnitOfWorkContext);
            KurumsalKullaniciRepository = new KurumsalKullaniciRepository(UnitOfWorkContext);
            MarkaRepository = new MarkaRepository(UnitOfWorkContext);
            OzellikBilgiRepository = new OzellikBilgiRepository(UnitOfWorkContext);
            OzellikRepository = new OzellikRepository(UnitOfWorkContext);
            PaketRepository = new PaketRepository(UnitOfWorkContext);
            RolRepository = new RolRepository(UnitOfWorkContext);
            RolYetkiRepository = new RolYetkiRepository(UnitOfWorkContext);
            StatuRepository = new StatuRepository(UnitOfWorkContext);
            StokRepository = new StokRepository(UnitOfWorkContext);
            TramerDetayRepository = new TramerDetayRepository(UnitOfWorkContext);
            YetkiRepository = new YetkiRepository(UnitOfWorkContext);
            SehirRepository = new SehirRepository(UnitOfWorkContext);
            IlceRepository = new IlceRepository(UnitOfWorkContext);
            SehirIlceRepository = new SehirIlceRepository(UnitOfWorkContext);
            ArabaModelRepository = new ArabaModelRepository(UnitOfWorkContext);
    }

        public IAracFiyatRepository AracFiyatRepository { get; private set; }

        public IAracOzellikRepository AracOzellikRepository { get; private set; }

        public IAracParcaRepository AracParcaRepository { get; private set; }

        public IAracRepository AracRepository { get; private set; }

        public IAracStatuRepository AracStatuRepository { get; private set; }

        public IAracTeklifRepository AracTeklifRepository { get; private set; }

        public IAracTramerDetayRepository AracTramerDetayRepository { get; private set; }

        public IAracTramerRepository AracTramerRepository { get; private set; }

        public ICalisanIletisimRepository CalisanIletisimRepository { get; private set; }

        public ICalisanRepository CalisanRepository { get; private set; }

        public IFavoriAramaKriterRepository FavoriAramaKriterRepository { get; private set; }

        public IFavoriAramaRepository FavoriAramaRepository { get; private set; }

        public IFavoriIlanRepository FavoriIlanRepository { get; private set; }

        public IFavoriOzellikRepository FavoriOzellikRepository { get; private set; }

        public IFirmaIletisimRepository FirmaIletisimRepository { get; private set; }

        public IFirmaRepository FirmaRepository { get; private set; }

        public IFirmaTipRepository FirmaTipRepository { get; private set; }

        public IFotografRepository FotografRepository { get; private set; }

        public IIhaleAracRepository IhaleAracRepository { get; private set; }

        public IIhaleRepository IhaleRepository { get; private set; }

        public IIhaleStatuRepository IhaleStatuRepository { get; private set; }

        public IIhaleSurecRepository IhaleSurecRepository { get; private set; }

        public IIlanRepository IlanRepository { get; private set; }

        public IIletisimTurRepository IletisimTurRepository { get; private set; }

        public IKullaniciIletisimRepository KullaniciIletisimRepository { get; private set; }

        public IKullaniciRepository KullaniciRepository { get; private set; }

        public IKullaniciTipRepository KullaniciTipRepository { get; private set; }

        public IKurumsalIhaleRepository KurumsalIhaleRepository { get; private set; }

        public IKurumsalKullaniciRepository KurumsalKullaniciRepository { get; private set; }

        public IMarkaRepository MarkaRepository { get; private set; }

        public IOzellikBilgiRepository OzellikBilgiRepository { get; private set; }

        public IOzellikRepository OzellikRepository { get; private set; }

        public IPaketRepository PaketRepository { get; private set; }

        public IRolRepository RolRepository { get; private set; }

        public IRolYetkiRepository RolYetkiRepository { get; private set; }

        public IStatuRepository StatuRepository { get; private set; }

        public IStokRepository StokRepository { get; private set; }

        public ITramerDetayRepository TramerDetayRepository { get; private set; }

        public IYetkiRepository YetkiRepository { get; private set; }

        public ISehirRepository SehirRepository { get; private set; }

        public IIlceRepository IlceRepository { get; private set; }

        public ISehirIlceRepository SehirIlceRepository { get; private set; }

        public IArabaModelRepository ArabaModelRepository { get; private set; }

        public int Complate()
        {
            return _unitOfWorkContext.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWorkContext.Dispose();
        }
    }
}
