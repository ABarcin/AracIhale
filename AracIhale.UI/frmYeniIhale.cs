using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracIhale.CORE.Login;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
using AracIhale.MODEL.VM;

namespace AracIhale.UI
{
    public partial class frmYeniIhale : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        IhaleListVM ihaleListVM = null;
        AracCDListVM arac = null;

        public frmYeniIhale()
        {
            InitializeComponent();
        }

        public frmYeniIhale(IhaleListVM _ihaleListVM) : this()
        {
            ihaleListVM = _ihaleListVM;
            AracListViewDoldur();
        }

        private void YeniIhale_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Login.GirisYapmisCalisan != null)
            {
                if (ihaleListVM == null)
                {
                    // Validation yapilacak
                    // EKLE

                    if (ValidateForm())
                    {
                        DialogResult result = MessageBox.Show("İhale eklemek istediğinize eminmisiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        ihaleListVM = new IhaleListVM();

                        if (result == DialogResult.Yes)
                        {
                            ihaleListVM.IhaleAdi = txtIhaleAdi.Text;
                            ihaleListVM.KullaniciTipID = (cmbUyeTip.SelectedItem as KullaniciTipVM).KullaniciTipID;
                            ihaleListVM.IhaleBaslangic = dtBaslangicSaat.Value;
                            ihaleListVM.IhaleBitis = dtIhaleBaslangic.Value;
                            ihaleListVM.BaslangicSaat = dtIhaleBitis.Value.TimeOfDay;
                            ihaleListVM.BitisSaat = dtBitisSaat.Value.TimeOfDay;
                            ihaleListVM.IhaleStatuID = (cmbStatu.SelectedItem as IhaleStatuVM).IhaleStatuID;
                            ihaleListVM.CalisanID = Login.GirisYapmisCalisan.CalisanID;
                            ihaleListVM.CreatedDate = DateTime.Now;
                            ihaleListVM.CreatedBy = Login.GirisYapmisCalisan.KullaniciAd;

                            unitOfWork.IhaleRepository.InsertIhaleVM(ihaleListVM);

                            if (unitOfWork.Complete() > 0)
                            {
                                MessageBox.Show("İhale ekleme başarılı");
                            }
                            else
                            {
                                MessageBox.Show("İhale ekleme başarısız");
                            }
                        }
                    }
                    ihaleListVM = null;
                }
                else
                {
                    // Validation yapilacak
                    // GUNCELLE

                    if (ValidateForm())
                    {
                        DialogResult result = MessageBox.Show("İhaleyi gücellemek istediğinize eminmisiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            ihaleListVM.IhaleAdi = txtIhaleAdi.Text;
                            ihaleListVM.KullaniciTipID = (cmbUyeTip.SelectedItem as KullaniciTipVM).KullaniciTipID;
                            ihaleListVM.IhaleBaslangic = dtIhaleBaslangic.Value;
                            ihaleListVM.IhaleBitis = dtIhaleBitis.Value;
                            ihaleListVM.BaslangicSaat = dtBaslangicSaat.Value.TimeOfDay;
                            ihaleListVM.BitisSaat = dtBitisSaat.Value.TimeOfDay;
                            ihaleListVM.IhaleStatuID = (cmbStatu.SelectedItem as IhaleStatuVM).IhaleStatuID;
                            ihaleListVM.ModifiedDate = DateTime.Now;
                            ihaleListVM.CalisanID = Login.GirisYapmisCalisan.CalisanID;
                            ihaleListVM.ModifiedBy = Login.GirisYapmisCalisan.KullaniciAd;

                            unitOfWork.IhaleRepository.UpdateIhaleVM(ihaleListVM);

                            if (unitOfWork.Complete() > 0)
                            {
                                MessageBox.Show("İhale güncelleme başarılı");
                            }
                            else
                            {
                                MessageBox.Show("İhale güncelleme başarısız");
                            }
                        }
                    }

                }
            }

            else
            {
                MessageBox.Show("Giriş yapmadınız. Lütfen giriş yapınız.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Kullanci ve calisan bossa butun formu kitler.
        /// </summary>
        private void LockForm() 
        {
            txtIhaleAdi.Enabled = false;
            cmbUyeTip.Enabled = false;
            cmbSirketAdi.Enabled = false;
            dtIhaleBaslangic.Enabled = false;
            dtIhaleBitis.Enabled = false;
            cmbStatu.Enabled = false;
            dtBaslangicSaat.Enabled = false;
            dtBitisSaat.Enabled = false;
            listArac.Enabled = false;
            btnAracEkle.Enabled = false;
            btnKaydet.Enabled = false;
            btnTeklifVer.Enabled = false;
        }

        /// <summary>
        /// Formu hazirlamasi icin gerekli olan metodu 
        /// cagiran metod.
        /// </summary>
        private void PrepareForm() 
        {
            if (Login.GirisYapmisCalisan != null && Login.GirisYapmisKullanici != null)
            {
                LockForm();
            }

            else if (Login.GirisYapmisCalisan != null)
            {
                PrepareFormForEmployee();
            }

            else if (Login.GirisYapmisKullanici != null)
            {
                PrepareFormForUser();
            }

            else
            {
                LockForm();
            }
        }

        /// <summary>
        /// Formu kullanicilarin gormesi gerektigi 
        /// sekilde hazirlar.
        /// </summary>
        private void PrepareFormForUser() 
        {
            btnTeklifVer.Enabled = false;
            txtIhaleAdi.Enabled = false;
            cmbUyeTip.Enabled = false;
            cmbSirketAdi.Enabled = false;
            dtIhaleBaslangic.Enabled = false;
            dtIhaleBitis.Enabled = false;
            cmbStatu.Enabled = false;
            dtBaslangicSaat.Enabled = false;
            dtBitisSaat.Enabled = false;
            btnAracEkle.Hide();
            btnKaydet.Hide();
            arac = null;
        }

        /// <summary>
        /// Formu calisanlarin gormesi gerektigi
        /// sekilde hazirlar.
        /// </summary>
        private void PrepareFormForEmployee() 
        {
            KullaniciTipComboBoxDoldur();
            IhaleStatuComboBoxDoldur();
            FirmaComboBoxDoldu();
            bilgileriGetir();
            AracListViewDoldur();

            PrepareFormForRole();

            btnTeklifVer.Hide();
        }

        private void PrepareFormForRole()
        {
            var rolYetki = Login.SayfaYetkiYonetimiListesi.FirstOrDefault(x => x.Sayfa.SayfaAdi == "frmYeniIhale");
            if (rolYetki.YetkiListesi.Count > 0)
            {
                if (rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Read"))
                {
                    if (!rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Create"))
                    {
                        btnAracEkle.Hide();
                        btnKaydet.Hide();
                    }
                    if (!rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Update"))
                    {
                        btnAracEkle.Hide();
                        btnKaydet.Hide();
                    }
                }
                else
                {
                    LockForm();
                }
            }
        }

        private bool ValidateForm()
        {
            bool IsValid = true;

            if (string.IsNullOrEmpty(txtIhaleAdi.Text))
            {
                IsValid = false;
                myErrorProvider.SetError(txtIhaleAdi,"Bu alan boş geçilemez");
            }
            else
            {
                myErrorProvider.Clear();
            }

            if(cmbStatu.SelectedIndex == 0)
            {
                IsValid = false;
                myErrorProvider.SetError(cmbStatu, "Bu alan boş geçilemez");
            }
            else
            {
                myErrorProvider.Clear();
            }

            if (cmbUyeTip.SelectedIndex == 0)
            {
                IsValid = false;
                myErrorProvider.SetError(cmbUyeTip, "Bu alan boş geçilemez");
            }
            else
            {
                myErrorProvider.Clear();
            }

            return IsValid;
        }

        private void bilgileriGetir()
        {
            if(ihaleListVM != null)
            {
                txtIhaleAdi.Text = ihaleListVM.IhaleAdi;

                dtIhaleBitis.Value = ihaleListVM.IhaleBaslangic;
                dtIhaleBaslangic.Value = ihaleListVM.IhaleBitis;

                DateTime dtBaslangic = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dtBaslangic = dtBaslangic + ihaleListVM.BaslangicSaat;

                dtBaslangicSaat.Value = dtBaslangic;

                DateTime dtBitis = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                dtBitis = dtBitis + ihaleListVM.BitisSaat;

                dtBitisSaat.Value = dtBitis;

                for (int i = cmbUyeTip.Items.Count - 1 ; i > 0; i--)
                {
                    KullaniciTipVM kullaniciTipVM = cmbUyeTip.Items[i] as KullaniciTipVM;

                    if (kullaniciTipVM.KullaniciTipID == ihaleListVM.KullaniciTipID)
                    {
                        cmbUyeTip.SelectedIndex = i;
                    }
                }

                for (int i = cmbStatu.Items.Count - 1; i > 0; i--)
                {
                    IhaleStatuVM ihaleStatuVM = cmbStatu.Items[i] as IhaleStatuVM;

                    if (ihaleStatuVM.IhaleStatuID == ihaleListVM.IhaleStatuID)
                    {
                        cmbStatu.SelectedIndex = i;
                    }
                }
            }

        }

        private void AracListViewDoldur()
        {
            if (ihaleListVM != null)
            {
                List<AracCDListVM> aracListVMler = unitOfWork.AracRepository.GetAracByIhaleID(ihaleListVM.IhaleID);

                listArac.Items.Clear();

                foreach (var item in aracListVMler)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = (listArac.Items.Count + 1).ToString();
                    listViewItem.SubItems.Add(item.Marka.Ad);
                    listViewItem.SubItems.Add(item.ArabaModel.Ad);
                    listViewItem.SubItems.Add(item.KullaniciTipAdi);
                    listViewItem.SubItems.Add(item.Statu.StatuAd);
                    listViewItem.SubItems.Add(item.Kullanici.Ad);
                    listViewItem.SubItems.Add(item.CreatedDate.ToString());

                    listViewItem.Tag = item;

                    listArac.Items.Add(listViewItem);
                }
            }
        }

        private void KullaniciTipComboBoxDoldur()
        {
            cmbUyeTip.Items.Add("Tip seçiniz");
            cmbUyeTip.SelectedIndex = 0;

            List<KullaniciTipVM> kullaniciTipVMler = unitOfWork.KullaniciTipRepository.GetKullaniciTipVM();

            if(kullaniciTipVMler != null)
            {
                cmbUyeTip.Items.AddRange(kullaniciTipVMler.ToArray());
            }
        }

        private void IhaleStatuComboBoxDoldur()
        {
            cmbStatu.Items.Add("Statu seçiniz");
            cmbStatu.SelectedIndex = 0;

            List<IhaleStatuVM> ihaleStatuVMler = unitOfWork.IhaleStatuRepository.GetIhaleStatuVM();

            if(ihaleStatuVMler != null)
            {
                cmbStatu.Items.AddRange(ihaleStatuVMler.ToArray());
            }
        }

        private void FirmaComboBoxDoldu()
        {
            cmbSirketAdi.Items.Add("Şirket seçiniz");
            cmbSirketAdi.SelectedIndex = 0;

            List<FirmaVM> firmaVMler = unitOfWork.FirmaRepository.GetFirmaVMler();

            if(firmaVMler != null)
            {
                cmbSirketAdi.Items.AddRange(firmaVMler.ToArray());
            }
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmIhaleAracFiyat ihaleAracFiyat=new frmIhaleAracFiyat(ihaleListVM))
            {
                ihaleAracFiyat.ShowDialog();
            }
            this.Show();
        }

        private void OnVisible_VisibleChanged(object sender, EventArgs e)
        {
            btnTeklifVer.Enabled = false;
            arac = null;

            AracListViewDoldur();
        }

        private void listArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listArac.SelectedItems.Count > 0 && Login.GirisYapmisKullanici != null)
            {
                arac = listArac.SelectedItems[0].Tag as AracCDListVM;

                if (arac != null)
                {
                    btnTeklifVer.Enabled = true;
                }

                MessageBox.Show($"'{arac.Marka.Ad} {arac.ArabaModel.Ad}' adli araç seçildi.");
            }
        }


        /// <summary>
        /// Arac teklif verme sayfasina giden metod.
        /// </summary>
        private void btnTeklifVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmBireyselTeklif bireyselTeklif = new frmBireyselTeklif(arac))
            {
                bireyselTeklif.ShowDialog();
            }
            this.Show();
        }
    }
}
