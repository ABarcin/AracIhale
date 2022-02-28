using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmCalisanKayit : Form
    {
        public frmCalisanKayit()
        {
            validation = new Validation();
            InitializeComponent();
        }
        private readonly Validation validation;
        CalisanIletisimMapping calisanIletisimMapping;
        CalisanVM tempCalisan = null;
        private void CalisanKayit_Load(object sender, EventArgs e)
        {
            ListCalisanlarDoldur();
            CmbRolDoldur();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AddCalisan();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.CalisanRepository.Sil((listCalisanlar.SelectedItems[0].Tag as CalisanVM).CalisanID);
                int etkilenen = unitOfWork.Complete();
                if (etkilenen > 0)
                {
                    FormuTemizle();
                }
                else
                {
                    errorProvider.SetError(btnSil, "Hata");
                }
            }

        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UpdateCalisan();
        }
        private void btnIletisim_Click(object sender, EventArgs e)
        {
            if (tempCalisan != null)
            {
                if (tempCalisan.CalisanID != 0)
                {
                    this.Hide();
                    using (frmIletisim frm = new frmIletisim(tempCalisan))
                    {
                        frm.ShowDialog();
                    }
                    this.Show();
                    IsEmailAdded();
                }
                else 
                {
                    MessageBox.Show("İletişim Bilgisi Eklemek İÇin Yeniden Kaydet Butonuna Basınız Ve Kaydetmek İçin Email Bilgisi Giriniz");
                }
            }
            else if (listCalisanlar.SelectedItems.Count > 0)
            {
                this.Hide();
                using (frmIletisim frm = new frmIletisim(listCalisanlar.SelectedItems[0].Tag as CalisanVM))
                {
                    frm.ShowDialog();
                }
                this.Show();
                IsEmailAdded();
            }
            else
            {
                errorProvider.SetError(btnIletisim, "İletişim Bilgisi Eklemek İçin Bir Kullanıcı Gerekli Ya Listeden Seçin Yada Yeni Bir Tane Oluşturun");
            }
        }

        private bool IsEmailAdded()
        {
            bool validate = false;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                List<CalisanIletisimVM> iletisimVM;
                if (listCalisanlar.SelectedItems.Count > 0)
                {
                    iletisimVM = unitOfWork.CalisanIletisimRepository.IletisimBilgileriniGetir(listCalisanlar.SelectedItems[0].Tag as CalisanVM);
                }
                else
                {
                    iletisimVM = unitOfWork.CalisanIletisimRepository.IletisimBilgileriniGetir(tempCalisan);
                }
                int count = iletisimVM.Where(x => x.IletisimTuruID == 1).Count();
                if (count > 0)
                {
                    validate = true;
                }
                else
                {
                    errorProvider.SetError(btnIletisim, "Çalışanın Emaili Girilmek Zorundadır");
                }
            }
            return validate;
        }

        private void listCalisanlar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            GetCalisanForUpdate();
        }
        /// <summary>
        /// Kendi yetkisine sahip yada kendisinden daha düşük yetkie sahip kişilerin rolleri yükleniyor.
        /// </summary>
        private void CmbRolDoldur()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                if (unitOfWork.RolRepository.TumRoller().Count > 0)
                {
                    foreach (RolVM item in unitOfWork.RolRepository.TumRoller().Where(x=>x.RolID==1||x.RolID==2))
                    {
                        if (item.RolID >= Login.GirisYapmisCalisan.RolID)
                        {
                            cmbRol.Items.Add(item);
                        }

                    }
                }
            }

        }
        private void ListCalisanlarDoldur()
        {
            if (listCalisanlar.Items.Count > 0)
            {
                listCalisanlar.Items.Clear();
            }
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                if (unitOfWork.CalisanRepository.TumCalisanlar().Count > 0)
                {
                    foreach (CalisanVM item in unitOfWork.CalisanRepository.TumCalisanlar())
                    {
                        string[] row = { item.Ad, item.Soyad, item.RolAd, item.AktiflikDurumu.ToString() };
                        var satir = new ListViewItem(row);
                        satir.Tag = item;
                        listCalisanlar.Items.Add(satir);
                    }
                }
            }


        }
        private void AddCalisan()
        {

            calisanIletisimMapping = new CalisanIletisimMapping();
            if ((validation.IsValidateName(txtAd, 2, 150, errorProvider) && validation.IsValidateName(txtSoyad, 2, 200, errorProvider) && validation.IsValidateUserName(txtKullaniciAdi, errorProvider, 3, 25) && validation.IsValidatePassWord(txtSifre, errorProvider, 3, 30) && SifreKontrol()) && RolControl())
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    using (TransactionScope scope = new TransactionScope())
                    {
                        try
                        {
                            CalisanVM calisan = new CalisanVM();
                            calisan.Ad = txtAd.Text;
                            calisan.Soyad = txtSoyad.Text;
                            calisan.KullaniciAd = txtKullaniciAdi.Text;
                            calisan.RolID = (cmbRol.SelectedItem as RolVM).RolID;
                            calisan.Sifre = txtSifre.Text;
                            if (rdbAktif.Checked == true)
                            {
                                calisan.AktiflikDurumu = true;
                            }
                            else
                            {
                                calisan.AktiflikDurumu = false;
                            }
                            unitOfWork.CalisanRepository.Ekle(calisan);
                            unitOfWork.Complete();
                            tempCalisan = calisan;
                            tempCalisan.CalisanID = unitOfWork.CalisanRepository.CalisanIdGetir();
                            DialogResult result = new DialogResult();
                            this.Hide();
                            using (frmIletisim frm = new frmIletisim(tempCalisan))
                            {
                                result = frm.ShowDialog();
                            }
                            this.Show();
                            if (result == DialogResult.Yes)
                            {
                                CalisanIletisimVM vm = unitOfWork.CalisanIletisimRepository.IletisimBilgileriniGetir(calisan).Where(x => x.IletisimTuruID == 1).FirstOrDefault();
                                if (vm != null)
                                {
                                    unitOfWork.LogRepository.AddLog(Text, "Çalışan Kaydı");
                                    unitOfWork.Complete();
                                    tempCalisan = null;
                                    scope.Complete();
                                    MessageBox.Show("Başarılı Bir Şekilde Eklendi");
                                    FormuTemizle();
                                }
                                else
                                {
                                    MessageBox.Show("İletişim eklemediğiniz için kayıt tamamlanamadı lütfen iletişim bilgisi ekleyiniz");
                                    unitOfWork.LogErrorRepository.AddLog(Text, "Çalışan Kaydı", "Eklenemedi");
                                    unitOfWork.Complete();
                                }
                            }
                            else
                            {
                                MessageBox.Show("İletişim eklemediğiniz için kayıt tamamlanamadı lütfen iletişim bilgisi ekleyiniz");
                            }
                        }
                        catch (Exception)
                        {
                            errorProvider.SetError(btnKaydet, "Hata Çıktı");
                        }
                    }
                    if (tempCalisan != null)
                    {
                        tempCalisan.CalisanID = 0; //kontrol için yazıldı
                    }

                }
                ListCalisanlarDoldur();
            }
            else
            {
                errorProvider.SetError(btnKaydet, "Hata");
            }
        }
        private bool RolControl()
        {
            if (cmbRol.SelectedIndex != -1)
            {
                return true;
            }
            errorProvider.SetError(btnKaydet, "Lütfen Rol Seçiniz");
            return false;
        }
        private void UpdateCalisan()
        {
            if (listCalisanlar.SelectedItems.Count > 0)
            {
                if ((listCalisanlar.SelectedItems[0].Tag as CalisanVM).RolID < Login.GirisYapmisCalisan.RolID)
                {
                    errorProvider.SetError(btnGuncelle, "Seçiğiniz Kişi Sizden Daha Üst Yetkiye Sahip Erişim Engellendi");
                }
                else
                {
                    if (validation.IsValidateName(txtAd, 3, 254, errorProvider) && validation.IsValidateName(txtSoyad, 3, 254, errorProvider) && validation.IsValidateUserName(txtKullaniciAdi, errorProvider, 3, 50))
                    {
                        CalisanVM vM = listCalisanlar.SelectedItems[0].Tag as CalisanVM;
                        vM.Ad = txtAd.Text;
                        vM.Soyad = txtSoyad.Text;
                        vM.RolID = (cmbRol.SelectedItem as RolVM).RolID;
                        vM.AktiflikDurumu = rdbAktif.Checked == true ? true : false;
                        using (UnitOfWork unitOfWork = new UnitOfWork())
                        {
                            unitOfWork.CalisanRepository.Guncelle(vM);
                            unitOfWork.Complete();
                        }

                        FormuTemizle();
                        ListCalisanlarDoldur();
                    }
                    else
                    {
                        errorProvider.SetError(btnGuncelle, "Hata");
                    }
                }
            }
            else
            {
                errorProvider.SetError(btnGuncelle, "Lütfen Güncellemek İstediğiniz Çalışanı Seçiniz");
            }
        }
        private void FormuTemizle()
        {
            txtAd.Text = txtKullaniciAdi.Text = txtSifre.Text = txtSifreTekrar.Text = txtSoyad.Text = string.Empty;
            rdbAktif.Checked = true;
            cmbRol.SelectedIndex = 1;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            btnGuncelle.Enabled = false;
            btnKaydet.Enabled = true;
            txtSifre.Enabled = true;
            txtSifreTekrar.Enabled = true;
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
        private void GetCalisanForUpdate()
        {
            if (listCalisanlar.SelectedItems.Count > 0)
            {
                if ((listCalisanlar.SelectedItems[0].Tag as CalisanVM).RolID < Login.GirisYapmisCalisan.RolID)
                {
                    errorProvider.SetError(btnGuncelle, "Seçiğiniz Kişi Sizden Daha Üst Yetkiye Sahip Erişim Engellendi");
                }
                else
                {
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                    btnKaydet.Enabled = false;
                    CalisanVM calisan = listCalisanlar.SelectedItems[0].Tag as CalisanVM;
                    txtAd.Text = calisan.Ad;
                    txtSoyad.Text = calisan.Soyad;
                    txtKullaniciAdi.Text = calisan.KullaniciAd;
                    txtSifre.Text = "Şifreyi Göremezsiniz";
                    txtSifre.Enabled = false;
                    txtSifreTekrar.Enabled = false;
                    if (calisan.AktiflikDurumu == true)
                    {
                        rdbAktif.Checked = true;
                    }
                    else
                    {
                        rdbPasif.Checked = true;
                    }
                    foreach (RolVM item in cmbRol.Items)
                    {
                        if (item.Ad == calisan.RolAd)
                        {
                            cmbRol.SelectedItem = item;
                        }
                    }
                }
            }
            else
            {
                FormuTemizle();
            }
        }
        private bool SifreKontrol()
        {
            bool dogruMu = false;
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                dogruMu = true;
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(txtSifreTekrar, "Şifreler Uyuşmuyor");
            }
            return dogruMu;
        }



    }
}
