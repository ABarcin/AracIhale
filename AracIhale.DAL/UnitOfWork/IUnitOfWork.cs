using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracIhale.DAL.Repositories.Abstract;

namespace AracIhale.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAracFiyatRepository AracFiyatRepository { get; }
        IAracOzellikRepository AracOzellikRepository { get; }
        IAracParcaRepository AracParcaRepository { get; }
        IAracRepository AracRepository { get; }
        IAracStatuRepository AracStatuRepository { get; }
        IAracTeklifRepository AracTeklifRepository { get; }
        IAracTramerDetayRepository AracTramerDetayRepository { get; }
        IAracTramerRepository AracTramerRepository { get; }
        ICalisanIletisimRepository CalisanIletisimRepository { get; }
        ICalisanRepository CalisanRepository { get; }
        IFavoriAramaKriterRepository FavoriAramaKriterRepository { get; }
        IFavoriAramaRepository FavoriAramaRepository { get; }
        IFavoriIlanRepository FavoriIlanRepository { get; }
        IFavoriOzellikRepository FavoriOzellikRepository { get; }
        IFirmaIletisimRepository FirmaIletisimRepository { get; }
        IFirmaRepository FirmaRepository { get; }
        IFirmaTipRepository FirmaTipRepository { get; }
        IFotografRepository FotografRepository { get; }
        IIhaleAracRepository IhaleAracRepository { get; }
        IIhaleRepository IhaleRepository { get; }
        IIhaleStatuRepository IhaleStatuRepository { get; }
        IIhaleSurecRepository IhaleSurecRepository { get; }
        IIlanRepository IlanRepository { get; }
        IIletisimTurRepository IletisimTurRepository { get; }
        IKullaniciIletisimRepository KullaniciIletisimRepository { get; }
        IKullaniciRepository KullaniciRepository { get; }
        IKullaniciTipRepository KullaniciTipRepository { get; }
        IKurumsalIhaleRepository KurumsalIhaleRepository { get; }
        IKurumsalKullaniciRepository KurumsalKullaniciRepository { get; }
        IMarkaRepository MarkaRepository { get; }
        IOzellikBilgiRepository OzellikBilgiRepository { get; }
        IOzellikRepository OzellikRepository { get; }
        IPaketRepository PaketRepository { get; }
        IRolRepository RolRepository { get; }
        IRolYetkiRepository RolYetkiRepository { get; }
        IStatuRepository StatuRepository { get; }
        IStokRepository StokRepository { get; }
        ITramerDetayRepository TramerDetayRepository { get; }
        IYetkiRepository YetkiRepository { get; }
        ISehirRepository SehirRepository { get; }
        IIlceRepository IlceRepository { get; }
        ISehirIlceRepository SehirIlceRepository { get; }
        IArabaModelRepository ArabaModelRepository { get; }
        ISayfaRepository SayfaRepository { get; }




        int Complete();
    }
}
