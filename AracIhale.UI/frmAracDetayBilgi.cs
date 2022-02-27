using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Mapping;
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

        UnitOfWork unitOfWork = new UnitOfWork();
        Validation validation = new Validation();
        AracVM aracVM;
        List<AracOzellikVM> aracOzellikVMs;
        AracFiyatVM aracFiyatVM;
        AracStatuVM aracStatuVM;
        KullaniciVM kullaniciVM;
        int _aracID;
        

        public frmAracDetayBilgi(AracListVM arac) : this()
        {
            _aracID = arac.AracID;
        }

        private void AracDetayBilgi_Load(object sender, EventArgs e)
        {
            PrepareFormByLoginUser();
        }

        int kullaniciID = 0;
        string modifiedBy = null;
        private void PrepareFormByLoginUser()
        {
            if (Login.GirisYapmisCalisan != null && Login.GirisYapmisKullanici != null)
            {
                LockForm();
            }

            else if (Login.GirisYapmisCalisan != null)
            {
                kullaniciID = Login.GirisYapmisCalisan.CalisanID;
                modifiedBy = Login.GirisYapmisCalisan.KullaniciAd;
                if (_aracID > 0)
                {
                    PrepareFormForUpdate();
                }
                else
                {
                    PrepareForm();
                }
            }

            else if (Login.GirisYapmisKullanici != null)
            {
                kullaniciID = Login.GirisYapmisKullanici.KullaniciID;
                modifiedBy = Login.GirisYapmisKullanici.KullaniciAd;
                if (_aracID > 0)
                {
                    PrepareFormForUpdate();
                }
                else
                {
                    PrepareForm();
                }
            }

            else
            {
                LockForm();
            }
        }

        private void LockForm()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
            }
        }

        private void PrepareFormForUpdate()
        {
            PrepareForm();

            #region Button States
            btnKaydet.Click -= btnKaydet_Click;
            btnKaydet.Click += btnGuncelle_Click;
            btnKaydet.Text = "Güncelle";
            btnTramerBilgileri.Enabled = true;
            btnIlanBilgileri.Enabled = true;
            btnHemenAlSatis.Enabled = true;
            btnAracTarihce.Enabled = true;
            btnKomisyon.Enabled = true;
            #endregion

            aracVM = unitOfWork.AracRepository.AracVMByAracID(_aracID);
            aracFiyatVM = unitOfWork.AracFiyatRepository.AracinGuncelFiyatiniGetir(_aracID);
            aracOzellikVMs = unitOfWork.AracOzellikRepository.AracOzellikleriniGetir(_aracID);
            aracStatuVM = unitOfWork.AracStatuRepository.AracinGuncelStatusunuGetir(_aracID);
            kullaniciVM = unitOfWork.KullaniciRepository.AracKullanicisiniGetir(_aracID);
            nmAracFiyat.Value = aracFiyatVM.Fiyat;
            nmKMBilgisi.Value = aracVM.Km;  
            
            #region Fill Comboboxes
            int index = -1;
            foreach (var item in cmbAracMarka.Items)
            {
                if ((item as MarkaVM).MarkaID == aracVM.MarkaID)
                {
                    index = cmbAracMarka.Items.IndexOf(item);
                    break;
                }
            }
            cmbAracMarka.SelectedIndex = index; index = -1;
            foreach (var item in cmbAracModel.Items)
            {
                if ((item as ArabaModelVM).ModelID  == aracVM.ModelID)
                {
                    index = cmbAracModel.Items.IndexOf(item);
                    break;
                }
            }
            cmbAracModel.SelectedIndex = index; index = -1;
            foreach (var item in cmbKullaniciTipi.Items)
            {
                if ((item as KullaniciTipVM).KullaniciTipID == kullaniciVM.KullaniciTipID)
                {
                    index = cmbKullaniciTipi.Items.IndexOf(item);
                    break;
                }
            }
            cmbKullaniciTipi.SelectedIndex = index; index = -1;
            foreach (var item in cmbStatu.Items)
            {
                if ((item as StatuVM).StatuID == aracStatuVM.StatuID)
                {
                    index = cmbStatu.Items.IndexOf(item);
                    break;
                }
            }
            cmbStatu.SelectedIndex = index; index = -1;
            foreach (int item in cmbAracYil.Items)
            {
                if (item == aracVM.Yil)
                {
                    index = cmbAracYil.Items.IndexOf(item);
                    break;
                }
            }cmbAracYil.SelectedIndex = index; index = -1;
            
            List<ComboBox> comboBoxes = new List<ComboBox>() { cmbGovdeTipi, cmbYakitTipi, cmbVitesTipi, cmbVersiyon, cmbRenk, cmbDonanim };
            for (int i = 0; i < aracOzellikVMs.Count; i++)
            {
                foreach (var item in comboBoxes[i].Items)
                {
                    if ((item as OzellikBilgiVM).OzellikBilgiID == aracOzellikVMs[i].OzellikBilgiID)
                    {
                        index = comboBoxes[i].Items.IndexOf(item);
                        break;
                    }
                }
                comboBoxes[i].SelectedIndex = index; index = -1;
            }
            #endregion
        }

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
                        // Araç ekleme methodumuzu çağırıyoruz. Araç Eklendikten sonra eklenen aracın id'sini diğer tablolarda kullanabilmek için değişkene alıyoruz.
                        _aracID = AracEkle();
                        unitOfWork.Complete();

                        // Araç ile ilişkili diğer tablolara AracID ile insert işlemi yapacağımız için,
                        // Arac tablosuna insert ettikten sonra eklenen son aracın ID'sini buluyoruz.
                        aracVM = new AracVM(){AracID = _aracID};

                        // Araç Fiyat ekleme methodumuzu çağırıyoruz.
                        AracFiyatEkle(_aracID);
                        unitOfWork.Complete();

                        // Araç Statü ekleme methodumuzu çağırıyoruz.
                        AracStatuEkle(_aracID);
                        unitOfWork.Complete();

                        // Aracın tüm özelliklerini insert edeceğimiz methodu çağırıyoruz.
                        AracOzellikEkle(_aracID);
                        unitOfWork.Complete();

                        scope.Complete();
                        MessageBox.Show("Araç kaydedildi.");
                        btnKaydet.Enabled = false;
                        btnTramerBilgileri.Enabled = true;
                        btnIlanBilgileri.Enabled = true;
                        btnHemenAlSatis.Enabled = true;
                        btnAracTarihce.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Araç eklenemedi.");
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    try
                    {
                        // Araç ekleme methodumuzu çağırıyoruz.
                        AracGuncelle();
                        unitOfWork.Complete();

                        // Araç ile ilişkili diğer tablolara AracID ile insert işlemi yapacağımız için,
                        // Arac tablosuna insert ettikten sonra eklenen son aracın ID'sini buluyoruz.
                        int aracID = unitOfWork.AracRepository.EklenenAracIDGetir();

                        // Araç Fiyatı değiştiyse fiyat güncelleme methodumuzu çağırıyoruz.
                        if (nmAracFiyat.Value != aracFiyatVM.Fiyat)
                        {
                            AracFiyatGuncelle();
                            unitOfWork.Complete();
                        }

                        // Araç Statü ekleme methodumuzu çağırıyoruz.
                        if ((cmbStatu.SelectedItem as StatuVM).StatuID != aracStatuVM.StatuID)
                        {
                            AracStatuGuncelle();
                            unitOfWork.Complete();
                        }
                        
                        // Aracın tüm özelliklerini insert edeceğimiz methodu çağırıyoruz.
                        AracOzellikGuncelle();
                        unitOfWork.Complete();

                        scope.Complete();
                        MessageBox.Show("Araç güncellendi.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Araç güncellenemedi.");
                    }
                }
            }
        }

        private void AracGuncelle()
        {
            // Arac tablosunda güncelleme yapmak için VM oluşturup repository içine gönderip güncelleme işlemini orada yapıyoruz.
            unitOfWork.AracRepository.AracGuncelle(new AracVM()
            {
                AracID = _aracID,
                MarkaID = (cmbAracMarka.SelectedItem as MarkaVM).MarkaID,
                ModelID = (cmbAracModel.SelectedItem as ArabaModelVM).ModelID,
                Km = Convert.ToInt32(nmKMBilgisi.Value),
                Yil = int.Parse(cmbAracYil.SelectedItem.ToString()),
                ModifiedDate = DateTime.Now,
                ModifiedBy = modifiedBy
            });
        }

        private int AracEkle()
        {
            // Arac tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz. Eklenen aracın ID'sini return ediyoruz.
            int aracID = unitOfWork.AracRepository.AracEkle(new AracVM()
            {
                KullaniciID = kullaniciID,
                MarkaID = (cmbAracMarka.SelectedItem as MarkaVM).MarkaID,
                ModelID = (cmbAracModel.SelectedItem as ArabaModelVM).ModelID,
                Km = Convert.ToInt32(nmKMBilgisi.Value),
                Yil = int.Parse(cmbAracYil.SelectedItem.ToString())
            });
            return aracID;
        }

        private void AracFiyatEkle(int aracID)
        {
            // AracFiyat tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
            // AracFiyatVM Komisyon methodunda kullanılacağı için object initializer kullanılmadı. 
            aracFiyatVM = new AracFiyatVM()
            {
                AracID = aracID,
                Fiyat = nmAracFiyat.Value,
                Tarih = DateTime.Now
            };
            unitOfWork.AracFiyatRepository.AracFiyatEkle(aracFiyatVM);
        }

        private void AracFiyatGuncelle()
        {
            // AracFiyat tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
            unitOfWork.AracFiyatRepository.AracFiyatEkle(new AracFiyatVM()
            {
                AracID = _aracID,
                Fiyat = nmAracFiyat.Value,
                Tarih = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ModifiedBy = modifiedBy
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

        private void AracStatuGuncelle()
        {
            // AracStatu tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
            unitOfWork.AracStatuRepository.AracStatuEkle(new AracStatuVM()
            {
                AracID = _aracID,
                StatuID = (cmbStatu.SelectedItem as StatuVM).StatuID,
                Tarih = DateTime.Now,
                ModifiedDate = DateTime.Now,
                ModifiedBy = modifiedBy
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

        private void AracOzellikGuncelle()
        {
            List<ComboBox> comboBoxes = new List<ComboBox>() { cmbGovdeTipi, cmbYakitTipi, cmbVitesTipi, cmbVersiyon, cmbRenk, cmbDonanim };
            for (int i = 0; i < aracOzellikVMs.Count; i++)
            {
                aracOzellikVMs[i].OzellikBilgiID = ((comboBoxes[i].SelectedItem as OzellikBilgiVM).OzellikBilgiID);
            }
            unitOfWork.AracOzellikRepository.AracOzellikGuncelle(aracOzellikVMs);
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
            
            if (aracVM != null)
            {
                this.Hide();
                using (frmTramerBilgileri tramerBilgileri = new frmTramerBilgileri(aracVM.AracID))
                {
                    tramerBilgileri.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Bu araç için tramer bilgileri ekranı gösterilemiyor.");
            }
        }

        private void btnIlanBilgileri_Click(object sender, EventArgs e)
        {
            
            if (aracVM != null)
            {
                this.Hide();
                using (frmIlanBilgileri ilanBilgileri = new frmIlanBilgileri(aracVM.AracID))
                {
                    ilanBilgileri.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Bu araç için ilan bilgileri ekranı gösterilemiyor.");
            }
            
        }

        private void btnAracTarihce_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAracTarihce aracTarihce = new frmAracTarihce(aracVM.AracID))
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
                cmbSirketAdi.SelectedIndex = -1;
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

        private void btnHemenAlSatis_Click(object sender, EventArgs e)
        {
            AracHemenAlSatis();
        }

        private void AracHemenAlSatis()
        {
            try
            {
                if (aracVM != null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Araç hemen al satış statüsüne geçirilecek. Onaylıyor musunuz?", "Hemen Al Satış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
                    {
                        // AracStatu tablosuna insert yapmak için VM oluşturup repository içine gönderip ekleme işlemini orada yapıyoruz.
                        unitOfWork.AracStatuRepository.AracStatuEkle(new AracStatuVM()
                        {
                            AracID = _aracID,
                            StatuID = unitOfWork.StatuRepository.HemenAlSatisStatuIDGetir(),
                            Tarih = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            ModifiedBy = modifiedBy
                        });
                        unitOfWork.Complete();
                        MessageBox.Show("Araç hemen al satış statüsüne geçirildi.");

                        foreach (var item in cmbStatu.Items)
                        {
                            if ((item as StatuVM).StatuAd == "Hemen Al Satış")
                            {
                                cmbStatu.SelectedIndex = cmbStatu.Items.IndexOf(item);
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Araç statüsü değiştirilemedi.");
            }
        }

        private void btnKomisyon_Click(object sender, EventArgs e)
        {
            int komisyon = 0;
            if (aracFiyatVM.Fiyat >= 0 && aracFiyatVM.Fiyat <=100000)
            {
                komisyon = 3000;
            }
            if (aracFiyatVM.Fiyat >= 100000 && aracFiyatVM.Fiyat < 300000)
            {
                komisyon = 4000;
            }
            if (aracFiyatVM.Fiyat >= 300000 && aracFiyatVM.Fiyat < 500000)
            {
                komisyon = 5000;
            }
            if (aracFiyatVM.Fiyat >= 500000 )
            {
                komisyon = 6000;
            }
            MessageBox.Show(string.Format("Komisyon ücreti: {0} TL",komisyon));
        }
    }
}
