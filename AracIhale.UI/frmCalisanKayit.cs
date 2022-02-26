using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.DAL.Repositories.Concrete;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmCalisanKayit : Form
    {
        public frmCalisanKayit()
        {
            InitializeComponent();
        }
        CalisanRepository repository;
        RolRepository rolRepository;
        Validation validation;
        UnitOfWork unitOfWork;
        CalisanIletisimMapping calisanIletisimMapping;
        CalisanVM tempCalisan = null;
        private void CalisanKayit_Load(object sender, EventArgs e)
        {
            ListCalisanlarDoldur();
            CmbRolDoldur();
            cmbRol.SelectedIndex = 1;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AddCalisan();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            unitOfWork = new UnitOfWork();
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
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UpdateCalisan();
        }
        private void btnIletisim_Click(object sender, EventArgs e)
        {
            if (tempCalisan != null)
            {
                this.Hide();
                using (frmIletisim frm = new frmIletisim(tempCalisan))
                {
                    frm.ShowDialog();
                }
                this.Show();
            }
            else if (listCalisanlar.SelectedItems.Count > 0)
            {
                this.Hide();
                using (frmIletisim frm = new frmIletisim(listCalisanlar.SelectedItems[0].Tag as CalisanVM))
                {
                    frm.ShowDialog();
                }
                this.Show();
            }
            else
            {
                errorProvider.SetError(btnIletisim, "İletişim Bilgisi Eklemek İçin Bir Kullanıcı Gerekli Ya Listeden Seçin Yada Yeni Bir Tane Oluşturun");
            }
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
            rolRepository = new RolRepository(new AracIhaleEntities());
            foreach (RolVM item in rolRepository.TumRoller())
            {
                if (item.RolID >= LoginKullanici.GirisYapmisCalisan.RolID)
                {
                    cmbRol.Items.Add(item);
                }

            }
        }
        private void ListCalisanlarDoldur()
        {
            if (listCalisanlar.Items.Count > 0)
            {
                listCalisanlar.Items.Clear();
            }
            repository = new CalisanRepository(new AracIhaleEntities());
            foreach (CalisanVM item in repository.TumCalisanlar())
            {
                string[] row = { item.Ad, item.Soyad, item.RolAd, item.AktiflikDurumu.ToString() };
                var satir = new ListViewItem(row);
                satir.Tag = item;
                listCalisanlar.Items.Add(satir);
            }
        }
        private void AddCalisan()
        {
            unitOfWork = new UnitOfWork();
            validation = new Validation();
            calisanIletisimMapping = new CalisanIletisimMapping();
            if ((validation.IsValidateName(txtAd, 2, 150, errorProvider) && validation.IsValidateName(txtSoyad, 2, 200, errorProvider) && validation.IsValidateUserName(txtKullaniciAdi, errorProvider, 3, 25) && validation.IsValidatePassWord(txtSifre, errorProvider, 3, 30) && SifreKontrol()))
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
                            CalisanIletisimVM vm= unitOfWork.CalisanIletisimRepository.IletisimBilgileriniGetir(calisan).Where(x=>x.IletisimTuruID==1).FirstOrDefault();
                            if (vm!=null)
                            {
                                unitOfWork.Complete();
                                scope.Complete();
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

                FormuTemizle();
                ListCalisanlarDoldur();
            }
            else
            {
                errorProvider.SetError(btnKaydet, "Hata");
            }
        }
        private void UpdateCalisan()
        {
            validation = new Validation();
            if (listCalisanlar.SelectedItems.Count > 0)
            {
                if ((listCalisanlar.SelectedItems[0].Tag as CalisanVM).RolID < LoginKullanici.GirisYapmisCalisan.RolID)
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
                        using (unitOfWork = new UnitOfWork())
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
                if ((listCalisanlar.SelectedItems[0].Tag as CalisanVM).RolID < LoginKullanici.GirisYapmisCalisan.RolID)
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
