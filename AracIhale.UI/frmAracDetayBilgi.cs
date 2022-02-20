using AracIhale.CORE;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmAracDetayBilgi : Form
    {
        public frmAracDetayBilgi()
        {
            InitializeComponent();
        }


        private void AracDetayBilgi_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }

        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        Validation validation = new Validation();

        private void PrepareForm()
        {
            cmbKullaniciTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            cmbStatu.Items.AddRange(unitOfWork.AracStatuRepository.StatuleriListele().ToArray());
            cmbAracMarka.Items.AddRange(unitOfWork.MarkaRepository.TumMarkalar().ToArray());
            cmbSirketAdi.Items.AddRange(unitOfWork.FirmaRepository.GetFirmaVMler().ToArray());
            cmbGovdeTipi.Items.AddRange(unitOfWork.OzellikRepository.GovdeTipiListele().ToArray());
            cmbYakitTipi.Items.AddRange(unitOfWork.OzellikRepository.YakitTipiListele().ToArray());
            cmbVitesTipi.Items.AddRange(unitOfWork.OzellikRepository.VitesTipiListele().ToArray());
            cmbVersiyon.Items.AddRange(unitOfWork.OzellikRepository.VersiyonListele().ToArray());
            cmbRenk.Items.AddRange(unitOfWork.OzellikRepository.RenkListele().ToArray());
            cmbDonanim.Items.AddRange(unitOfWork.OzellikRepository.DonanimListele().ToArray());
            for (int d = DateTime.Now.Year; d >= 1900; d--)
            {
                cmbAracYil.Items.Add(d);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        // Araç ekleme methodumuzu çağırıyoruz.
                        AracEkle();
                        unitOfWork.Complate();

                        // Araç ile ilişkili diğer tablolara AracID ile insert işlemi yapacağımız için,
                        // Arac tablosuna insert ettikten sonra eklenen son aracın ID'sini buluyoruz.
                        int aracID = unitOfWork.AracRepository.SonAracIDGetir();

                        // Araç Fiyat ekleme methodumuzu çağırıyoruz.
                        AracFiyatEkle(aracID);
                        unitOfWork.Complate();

                        // Araç Statü ekleme methodumuzu çağırıyoruz.
                        AracStatuEkle(aracID);
                        unitOfWork.Complate();

                        // Aracın tüm özelliklerini insert edeceğimiz methodu çağırıyoruz.
                        AracOzellikEkle(aracID);
                        unitOfWork.Complate();

                        scope.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Araç eklenemedi.");
                    }
                }
            }
            else
            {

            }
        }

        private void AracEkle()
        {
            // Arac tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
            unitOfWork.AracRepository.AracEkle(new AracVM()
            {
                KullaniciID = 1,
                MarkaID = (cmbAracMarka.SelectedItem as MarkaVM).MarkaID,
                ModelID = (cmbAracModel.SelectedItem as ArabaModelVM).ModelID,
                Km = nmKMBilgisi.Value,
                Yil = int.Parse(cmbAracYil.SelectedItem.ToString())
            });
        }

        private void AracFiyatEkle(int aracID)
        {
            // AracFiyat tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
            unitOfWork.AracFiyatRepository.AracFiyatEkle(new AracFiyatVM()
            {
                AracID = aracID,
                Fiyat = nmAracFiyat.Value,
                Tarih = DateTime.Now
            });
        }

        private void AracStatuEkle(int aracID)
        {
            // AracStatu tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
            unitOfWork.AracStatuRepository.AracStatuEkle(new AracStatuVM()
            {
                AracID = aracID,
                StatuID = (cmbStatu.SelectedItem as StatuVM).StatuID,
                Tarih = DateTime.Now
            });
        }

        private void AracOzellikEkle(int aracID)
        {
            List<AracOzellikVM> aracOzellikVMs = new List<AracOzellikVM>();

            // Gövde Tipini AracOzellik tablosuna insert etmek için VM oluşturup tüm özellikleri bir araya toplayacağımız listeye ekliyoruz
            aracOzellikVMs.Add(new AracOzellikVM()
            {
                AracID = aracID,
                AracOzellikID = (cmbGovdeTipi.SelectedItem as OzellikBilgiVM).OzellikID,
                OzellikBilgiID = (cmbGovdeTipi.SelectedItem as OzellikBilgiVM).OzellikBilgiID
            });
            // Yakıt Tipini AracOzellik tablosuna insert etmek için VM oluşturup tüm özellikleri bir araya toplayacağımız listeye ekliyoruz
            aracOzellikVMs.Add(new AracOzellikVM()
            {
                AracID = aracID,
                AracOzellikID = (cmbYakitTipi.SelectedItem as OzellikBilgiVM).OzellikID,
                OzellikBilgiID = (cmbYakitTipi.SelectedItem as OzellikBilgiVM).OzellikBilgiID
            });
            // Vites Tipini AracOzellik tablosuna insert etmek için VM oluşturup tüm özellikleri bir araya toplayacağımız listeye ekliyoruz
            aracOzellikVMs.Add(new AracOzellikVM()
            {
                AracID = aracID,
                AracOzellikID = (cmbVitesTipi.SelectedItem as OzellikBilgiVM).OzellikID,
                OzellikBilgiID = (cmbVitesTipi.SelectedItem as OzellikBilgiVM).OzellikBilgiID
            });
            // Versiyonu AracOzellik tablosuna insert etmek için VM oluşturup tüm özellikleri bir araya toplayacağımız listeye ekliyoruz
            aracOzellikVMs.Add(new AracOzellikVM()
            {
                AracID = aracID,
                AracOzellikID = (cmbVersiyon.SelectedItem as OzellikBilgiVM).OzellikID,
                OzellikBilgiID = (cmbVersiyon.SelectedItem as OzellikBilgiVM).OzellikBilgiID
            });
            // Rengi AracOzellik tablosuna insert etmek için VM oluşturup tüm özellikleri bir araya toplayacağımız listeye ekliyoruz
            aracOzellikVMs.Add(new AracOzellikVM()
            {
                AracID = aracID,
                AracOzellikID = (cmbRenk.SelectedItem as OzellikBilgiVM).OzellikID,
                OzellikBilgiID = (cmbRenk.SelectedItem as OzellikBilgiVM).OzellikBilgiID
            });
            // Donanım AracOzellik tablosuna insert etmek için VM oluşturup tüm özellikleri bir araya toplayacağımız listeye ekliyoruz
            aracOzellikVMs.Add(new AracOzellikVM()
            {
                AracID = aracID,
                AracOzellikID = (cmbDonanim.SelectedItem as OzellikBilgiVM).OzellikID,
                OzellikBilgiID = (cmbDonanim.SelectedItem as OzellikBilgiVM).OzellikBilgiID
            });

            // Tüm araç özelliklerini topladığımız listeyi repository içindeki methodumuza gönderip insert işlemini orada yapıyoruz.
            unitOfWork.AracOzellikRepository.AracOzellikEkle(aracOzellikVMs);
        }

        private bool IsValidate()
        {
            bool isValid = false;
            if (cmbKullaniciTipi.SelectedItem != null && cmbKullaniciTipi.SelectedItem.ToString() == "Kurumsal")
            {
                if (validation.IsValidateCombobox(new List<ComboBox>() {cmbKullaniciTipi, cmbSirketAdi ,cmbStatu, cmbAracMarka, cmbAracModel, cmbAracYil, cmbGovdeTipi,
                    cmbYakitTipi, cmbVitesTipi, cmbVersiyon, cmbRenk, cmbDonanim}, errorProvider)
                    && validation.IsValidateNumericUpDown(new List<NumericUpDown>() { nmAracFiyat, nmKMBilgisi }, errorProvider))
                {
                    isValid = true;
                }
            }
            else
            {
                if (validation.IsValidateCombobox(new List<ComboBox>() {cmbKullaniciTipi, cmbStatu, cmbAracMarka, cmbAracModel, cmbAracYil, cmbGovdeTipi,
                    cmbYakitTipi, cmbVitesTipi, cmbVersiyon, cmbRenk, cmbDonanim}, errorProvider)
                    && validation.IsValidateNumericUpDown(new List<NumericUpDown>() { nmAracFiyat, nmKMBilgisi }, errorProvider))
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private void ListModelsByMarka()
        {
            cmbAracModel.Items.Clear();
            cmbAracModel.Items.AddRange(unitOfWork.ArabaModelRepository.ModelListele(cmbAracMarka.SelectedItem as MarkaVM).ToArray());
        }


        private void btnTramerBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (TramerBilgileri tramerBilgileri = new TramerBilgileri())
            {
                tramerBilgileri.ShowDialog();
            }
            this.Show();
        }

        private void btnIlanBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (IlanBilgileri ilanBilgileri = new IlanBilgileri())
            {
                ilanBilgileri.ShowDialog();
            }
            this.Show();
        }

        private void btnAracTarihce_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AracTarihce aracTarihce = new AracTarihce())
            {
                aracTarihce.ShowDialog();
            }
            this.Show();
        }

        private void btnAliciBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AliciBilgileri aliciBilgileri = new AliciBilgileri())
            {
                aliciBilgileri.ShowDialog();
            }
            this.Show();
        }

        private void cmbKullaniciTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullaniciTipi.SelectedItem.ToString() == "Kurumsal")
            {
                cmbSirketAdi.Enabled = true;
            }
            else
            {
                cmbSirketAdi.Enabled = false;
            }
        }

        private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAracMarka.SelectedIndex > -1)
            {
                ListModelsByMarka();
            }
        }


    }
}
