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

        public UnitOfWork()
        {
            _unitOfWorkContext = new AracIhaleEntities();
            AracFiyatRepository = new AracFiyatRepository(_unitOfWorkContext);
            AracOzellikRepository = new AracOzellikRepository(_unitOfWorkContext);
            AracParcaRepository = new AracParcaRepository(_unitOfWorkContext);
            AracRepository = new AracRepository(_unitOfWorkContext);
            AracStatuRepository = new AracStatuRepository(_unitOfWorkContext);
            AracTeklifRepository = new AracTeklifRepository(_unitOfWorkContext);
            AracTramerDetayRepository = new AracTramerDetayRepository(_unitOfWorkContext);
            AracTramerRepository = new AracTramerRepository(_unitOfWorkContext);
            CalisanIletisimRepository = new CalisanIletisimRepository(_unitOfWorkContext);
            CalisanRepository = new CalisanRepository(_unitOfWorkContext);
            FavoriAramaKriterRepository = new FavoriAramaKriterRepository(_unitOfWorkContext);
            FavoriAramaRepository = new FavoriAramaRepository(_unitOfWorkContext);
            FavoriIlanRepository = new FavoriIlanRepository(_unitOfWorkContext);
            FavoriOzellikRepository = new FavoriOzellikRepository(_unitOfWorkContext);
            FirmaIletisimRepository = new FirmaIletisimRepository(_unitOfWorkContext);
            FirmaRepository = new FirmaRepository(_unitOfWorkContext);
            FirmaTipRepository = new FirmaTipRepository(_unitOfWorkContext);
            FirmaTipRepository = new FirmaTipRepository(_unitOfWorkContext);
            IhaleAracRepository = new IhaleAracRepository(_unitOfWorkContext);
            IhaleRepository = new IhaleRepository(_unitOfWorkContext);
            IhaleStatuRepository = new IhaleStatuRepository(_unitOfWorkContext);
            IhaleSurecRepository = new IhaleSurecRepository(_unitOfWorkContext);
            IlanRepository = new IlanRepository(_unitOfWorkContext);
            IletisimTurRepository = new IletisimTurRepository(_unitOfWorkContext);
            KullaniciIletisimRepository = new KullaniciIletisimRepository(_unitOfWorkContext);
            KullaniciRepository = new KullaniciRepository(_unitOfWorkContext);
            KullaniciTipRepository = new KullaniciTipRepository(_unitOfWorkContext);
            KurumsalIhaleRepository = new KurumsalIhaleRepository(_unitOfWorkContext);
            KurumsalKullaniciRepository = new KurumsalKullaniciRepository(_unitOfWorkContext);
            MarkaRepository = new MarkaRepository(_unitOfWorkContext);
            OzellikBilgiRepository = new OzellikBilgiRepository(_unitOfWorkContext);
            OzellikRepository = new OzellikRepository(_unitOfWorkContext);
            PaketRepository = new PaketRepository(_unitOfWorkContext);
            RolRepository = new RolRepository(_unitOfWorkContext);
            RolYetkiRepository = new RolYetkiRepository(_unitOfWorkContext);
            StatuRepository = new StatuRepository(_unitOfWorkContext);
            StokRepository = new StokRepository(_unitOfWorkContext);
            TramerDetayRepository = new TramerDetayRepository(_unitOfWorkContext);
            YetkiRepository = new YetkiRepository(_unitOfWorkContext);
            SehirRepository = new SehirRepository(_unitOfWorkContext);
            IlceRepository = new IlceRepository(_unitOfWorkContext);
            SehirIlceRepository = new SehirIlceRepository(_unitOfWorkContext);
            ArabaModelRepository = new ArabaModelRepository(_unitOfWorkContext);
            SayfaRepository = new SayfaRepository(_unitOfWorkContext);

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
        public ISayfaRepository SayfaRepository { get; private set; }

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
