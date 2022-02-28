using AracIhale.CORE.Login;
using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmIhaleListeleme : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        IhaleListVM ihaleListVM = null;

        public frmIhaleListeleme()
        {
            InitializeComponent();
        }

        private void IhaleListeleme_Load(object sender, EventArgs e)
        {
            //// Silinmesi gerekiyor. Test icin.
            //Login.GirisYapmisCalisan = new CalisanVM()
            //{
            //    CalisanID = 1
            //};

            // Silinmesi gerekiyor. Test icin.
            //Login.GirisYapmisKullanici = new KullaniciVM()
            //{
            //    KullaniciID = 2,
            //};

            PrepareForm();
        }

        /// <summary>
        /// Kullanci ve calisan bossa butun formu kitler.
        /// </summary>
        private void LockForm()
        {
            txtIhaleAdi.Enabled = false;
            cmbUyeTipi.Enabled = false;
            cmbStatu.Enabled = false;
            listIhaleler.Enabled = false;
            btnListele.Hide();
            btnYeni.Hide();
            btnGuncelle.Hide();
            btnSil.Hide();
            btnIhaleArac.Hide();
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
            txtIhaleAdi.Enabled = false;
            cmbUyeTipi.Enabled = false;
            cmbStatu.Enabled = false;
            btnIhaleArac.Enabled = false;
            btnListele.Hide();
            btnYeni.Hide();
            btnGuncelle.Hide();
            btnSil.Hide();
        }

        /// <summary>
        /// Formu calisanlarin gormesi gerektigi
        /// sekilde hazirlar.
        /// </summary>
        private void PrepareFormForEmployee()
        {
            cmbUyeTipi.Items.Clear();
            cmbStatu.Items.Clear();

            PrepareFormForRole();

            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

            cmbUyeTipi.Items.Add("Uye Tipi Seciniz");

            if(unitOfWork.KullaniciTipRepository.KullaniciTipListele() != null)
            {
                cmbUyeTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            }
            
            cmbStatu.Items.Add("Statu Seciniz");

            if (unitOfWork.IhaleStatuRepository.StatuleriListele() != null)
            {
                cmbStatu.Items.AddRange(unitOfWork.IhaleStatuRepository.StatuleriListele().ToArray());
            }

            cmbUyeTipi.SelectedIndex = 0;
            cmbStatu.SelectedIndex = 0;

            btnIhaleArac.Hide();

            SetDefaultValueAndFillListView();
        }

        private void PrepareFormForRole()
        {
            var rolYetki = Login.SayfaYetkiYonetimiListesi.FirstOrDefault(x => x.Sayfa.SayfaAdi == "frmIhaleListeleme");
            if (rolYetki.YetkiListesi.Count > 0)
            {
                if (rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Read"))
                {
                    if (!rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Create"))
                    {
                        btnYeni.Hide();
                    }
                    if (!rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Update"))
                    {
                        btnGuncelle.Hide();
                    }
                    if (!rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Delete"))
                    {
                        btnSil.Hide();
                    }
                }
                else
                {
                    LockForm();
                }
            }
        }

        /// <summary>
        /// Listele butonuna basildiginda gerekli filtrelemelerin
        /// yapidigi metod.
        /// </summary>
        private void btnListele_Click(object sender, EventArgs e)
        {
            SetDefaultValueAndFillListView();
        }

        /// <summary>
        /// Listview'a gerekli verilerin eklendigi metod.
        /// </summary>
        /// <param name="ihaleListVMs">Gerekli filtrelemelerin yapildigi liste</param>
        private void FiltrelenenIhaleleriListele(List<IhaleListVM> ihaleListVMs)
        {
            listIhaleler.Items.Clear();
            foreach (IhaleListVM ihale in ihaleListVMs)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (listIhaleler.Items.Count + 1).ToString();
                li.SubItems.Add(ihale.IhaleAdi);
                li.SubItems.Add(ihale.KullaniciTip);
                li.SubItems.Add(ihale.IhaleBaslangic.ToShortDateString());
                li.SubItems.Add(ihale.IhaleBitis.ToShortDateString());
                li.SubItems.Add(ihale.IhaleDurum);
                li.SubItems.Add(ihale.KullaniciAd);
                li.SubItems.Add(ihale.CreatedDate.ToString());
                li.Tag = ihale;

                listIhaleler.Items.Add(li);
            }
        }

        /// <summary>
        /// Filtrelemelerin yapildigi ve FiltrelenenIhaleleriListele
        /// metodunu cagirarak listview'in doldurulmasina katki saglayan metod.
        /// </summary>
        private void SetDefaultValueAndFillListView()
        {
            string ihaleAdi = "";
            KullaniciTipVM kullaniciTip = null;
            StatuVM statu = null;

            if (!string.IsNullOrEmpty(txtIhaleAdi.Text))
            {
                ihaleAdi = txtIhaleAdi.Text;
            }

            if (cmbUyeTipi.SelectedIndex != 0)
            {
                kullaniciTip = cmbUyeTipi.SelectedItem as KullaniciTipVM;
            }

            if(cmbStatu.SelectedIndex != 0)
            {
                statu = cmbStatu.SelectedItem as StatuVM;
            }

            FiltrelenenIhaleleriListele(unitOfWork.IhaleRepository.IhaleListele(ihaleAdi, kullaniciTip, statu));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmYeniIhale yeniIhale=new frmYeniIhale())
            {
                yeniIhale.ShowDialog();
            }
            this.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmYeniIhale yeniIhale = new frmYeniIhale(ihaleListVM))
            {
                yeniIhale.ShowDialog();
            }
            this.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(ihaleListVM != null)
            {
                DialogResult result = MessageBox.Show("İhaleyi silmek istediğinize eminmisiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ihaleListVM.IsActive = false;

                    unitOfWork.IhaleRepository.UpdateIhaleVM(ihaleListVM);

                    if (unitOfWork.Complete() > 0)
                    {
                        MessageBox.Show("İhale silme başarılı");
                    }
                    else
                    {
                        MessageBox.Show("İhale silme başarısız");
                    }

                    btnGuncelle.Enabled = false;
                    btnSil.Enabled = false;

                    ihaleListVM = null;

                    SetDefaultValueAndFillListView();
                }
            }
        }

        private void listIhaleler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIhaleler.SelectedItems.Count > 0)
            {
                ihaleListVM = listIhaleler.SelectedItems[0].Tag as IhaleListVM;

                if(ihaleListVM != null)
                {
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                    btnIhaleArac.Enabled = true;
                }

                MessageBox.Show($"'{ihaleListVM.IhaleAdi}' adlı ihale seçildi.");
            }
        }

        private void OnVisible_VisibleChanged(object sender, EventArgs e)
        {
            if(Login.GirisYapmisCalisan != null || Login.GirisYapmisKullanici != null)
            {
                PrepareForm();

                SetDefaultValueAndFillListView();
            }
        }

        private void btnIhaleArac_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmYeniIhale yeniIhale = new frmYeniIhale(ihaleListVM))
            {
                yeniIhale.ShowDialog();
            }
            this.Show();
        }
    }
}
