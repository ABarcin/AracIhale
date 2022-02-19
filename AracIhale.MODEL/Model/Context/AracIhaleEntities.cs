using AracIhale.MODEL.Model.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AracIhale.MODEL.Model.Context

{
    public partial class AracIhaleEntities : DbContext
    {
        public AracIhaleEntities()
            : base("data source=.;database=Slytherin_AracIhale;uid=buraktoglu;pwd=963633")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<ArabaModel> ArabaModel { get; set; }
        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracFiyat> AracFiyat { get; set; }
        public virtual DbSet<AracOzellik> AracOzellik { get; set; }
        public virtual DbSet<AracParca> AracParca { get; set; }
        public virtual DbSet<AracStatu> AracStatu { get; set; }
        public virtual DbSet<AracTeklif> AracTeklif { get; set; }
        public virtual DbSet<AracTramer> AracTramer { get; set; }
        public virtual DbSet<AracTramerDetay> AracTramerDetay { get; set; }
        public virtual DbSet<Calisan> Calisan { get; set; }
        public virtual DbSet<CalisanIletisim> CalisanIletisim { get; set; }
        public virtual DbSet<FavoriArama> FavoriArama { get; set; }
        public virtual DbSet<FavoriAramaKriter> FavoriAramaKriter { get; set; }
        public virtual DbSet<FavoriIlan> FavoriIlan { get; set; }
        public virtual DbSet<FavoriOzellik> FavoriOzellik { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<FirmaIletisim> FirmaIletisim { get; set; }
        public virtual DbSet<FirmaTip> FirmaTip { get; set; }
        public virtual DbSet<Fotograf> Fotograf { get; set; }
        public virtual DbSet<Ihale> Ihale { get; set; }
        public virtual DbSet<IhaleArac> IhaleArac { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatu { get; set; }
        public virtual DbSet<IhaleSurec> IhaleSurec { get; set; }
        public virtual DbSet<Ilan> Ilan { get; set; }
        public virtual DbSet<Ilce> Ilce { get; set; }
        public virtual DbSet<IletisimTur> IletisimTur { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciIletisim> KullaniciIletisim { get; set; }
        public virtual DbSet<KullaniciTip> KullaniciTip { get; set; }
        public virtual DbSet<KurumsalIhale> KurumsalIhale { get; set; }
        public virtual DbSet<KurumsalKullanici> KurumsalKullanici { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Ozellik> Ozellik { get; set; }
        public virtual DbSet<OzellikBilgi> OzellikBilgi { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolYetki> RolYetki { get; set; }
        public virtual DbSet<Sehir> Sehir { get; set; }
        public virtual DbSet<SehirIlce> SehirIlce { get; set; }
        public virtual DbSet<Statu> Statu { get; set; }
        public virtual DbSet<Stok> Stok { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TramerDetay> TramerDetay { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }
        public virtual DbSet<Ekspertiz> Ekspertiz { get; set; }
        public virtual DbSet<Sayfa> Sayfa { get; set; }
        public virtual DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArabaModel>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.ArabaModel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .Property(e => e.KullaniciID);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.AracFiyat)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.AracOzellik)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.AracStatu)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.AracTramer)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.Fotograf)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.IhaleArac)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Arac>()
                .HasMany(e => e.Ilan)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AracFiyat>()
                .Property(e => e.Fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AracParca>()
                .HasMany(e => e.AracTramerDetay)
                .WithRequired(e => e.AracParca)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AracTeklif>()
                .Property(e => e.KullaniciID);

            modelBuilder.Entity<AracTeklif>()
                .Property(e => e.TeklifFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AracTramer>()
                .Property(e => e.Fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<AracTramer>()
                .HasMany(e => e.AracTramerDetay)
                .WithRequired(e => e.AracTramer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Calisan>()
                .Property(e => e.KullaniciAd)
                .IsFixedLength();

            modelBuilder.Entity<Calisan>()
                .HasMany(e => e.CalisanIletisim)
                .WithRequired(e => e.Calisan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Calisan>()
                .HasMany(e => e.Ihale)
                .WithRequired(e => e.Calisan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FavoriArama>()
                .Property(e => e.KullaniciID);

            modelBuilder.Entity<FavoriAramaKriter>()
                .Property(e => e.BaslangicFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FavoriAramaKriter>()
                .Property(e => e.BitisFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FavoriAramaKriter>()
                .HasMany(e => e.FavoriArama)
                .WithRequired(e => e.FavoriAramaKriter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FavoriAramaKriter>()
                .HasMany(e => e.FavoriOzellik)
                .WithRequired(e => e.FavoriAramaKriter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FavoriIlan>()
                .Property(e => e.KullaniciID);

            modelBuilder.Entity<Firma>()
                .HasMany(e => e.FirmaIletisim)
                .WithRequired(e => e.Firma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Firma>()
                .HasMany(e => e.KurumsalKullanici)
                .WithRequired(e => e.Firma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Firma>()
                .HasMany(e => e.Stok)
                .WithRequired(e => e.Firma)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ihale>()
                .Property(e => e.IhaleAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Ihale>()
                .HasMany(e => e.IhaleArac)
                .WithRequired(e => e.Ihale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ihale>()
                .HasMany(e => e.IhaleSurec)
                .WithRequired(e => e.Ihale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ihale>()
                .HasMany(e => e.KurumsalIhale)
                .WithRequired(e => e.Ihale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IhaleArac>()
                .Property(e => e.IhaleBaslangicFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IhaleArac>()
                .Property(e => e.MinAlimFiyati)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IhaleArac>()
                .HasMany(e => e.AracTeklif)
                .WithRequired(e => e.IhaleArac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IhaleStatu>()
                .HasMany(e => e.IhaleSurec)
                .WithRequired(e => e.IhaleStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ilan>()
                .Property(e => e.Baslik)
                .IsUnicode(false);

            modelBuilder.Entity<Ilan>()
                .Property(e => e.Aciklama)
                .IsUnicode(false);

            modelBuilder.Entity<Ilan>()
                .HasMany(e => e.FavoriIlan)
                .WithRequired(e => e.Ilan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ilce>()
                .HasMany(e => e.SehirIlce)
                .WithRequired(e => e.Ilce)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IletisimTur>()
                .HasMany(e => e.CalisanIletisim)
                .WithRequired(e => e.IletisimTur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IletisimTur>()
                .HasMany(e => e.FirmaIletisim)
                .WithRequired(e => e.IletisimTur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IletisimTur>()
                .HasMany(e => e.KullaniciIletisim)
                .WithRequired(e => e.IletisimTur)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.KullaniciAd)
                .IsFixedLength();

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.AracTeklif)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.FavoriArama)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.FavoriIlan)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.KullaniciIletisim)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.KurumsalKullanici)
                .WithRequired(e => e.Kullanici)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciIletisim>()
                .Property(e => e.KullaniciID);

            modelBuilder.Entity<KullaniciTip>()
                .HasMany(e => e.Ihale)
                .WithRequired(e => e.KullaniciTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KullaniciTip>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.KullaniciTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KurumsalKullanici>()
                .Property(e => e.KullaniciID);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Arac)
                .WithRequired(e => e.Marka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ozellik>()
                .HasMany(e => e.OzellikBilgi)
                .WithRequired(e => e.Ozellik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OzellikBilgi>()
                .HasMany(e => e.AracOzellik)
                .WithRequired(e => e.OzellikBilgi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OzellikBilgi>()
                .HasMany(e => e.FavoriOzellik)
                .WithRequired(e => e.OzellikBilgi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Calisan)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.Kullanici)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.RolYetki)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sehir>()
                .HasMany(e => e.SehirIlce)
                .WithRequired(e => e.Sehir)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Statu>()
                .HasMany(e => e.AracStatu)
                .WithRequired(e => e.Statu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TramerDetay>()
                .HasMany(e => e.AracTramerDetay)
                .WithRequired(e => e.TramerDetay)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Yetki>()
                .HasMany(e => e.RolYetki)
                .WithRequired(e => e.Yetki)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ekspertiz>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<Ekspertiz>()
                .Property(e => e.Adres)
                .IsUnicode(false);
        }
    }
}
