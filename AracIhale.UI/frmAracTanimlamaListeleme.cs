using AracIhale.CORE.Login;
using AracIhale.DAL.UnitOfWork;
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
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmAracTanimlamaListeleme : Form
    {
        public frmAracTanimlamaListeleme()
        {
            InitializeComponent();
        }
        UnitOfWork unitOfWork = new UnitOfWork();
        int _kullaniciID = 0;
        int _calisanID = 0;

        private void AracTanimlama_Load(object sender, EventArgs e)
        {
            lstAracListesi.Items.Clear();
            //Login.GirisYapmisCalisan = new CalisanVM { CalisanID = 1 };
            Login.GirisYapmisKullanici = new KullaniciVM { KullaniciID = 8 };
            PrepareForm();
        }

        private void PrepareForm()
        {
            cmbAracMarka.Items.AddRange(unitOfWork.MarkaRepository.TumMarkalar().ToArray());
            cmbKullaniciTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            cmbStatu.Items.AddRange(unitOfWork.AracStatuRepository.StatuleriListele().ToArray());
            PrepareFormByLoginUser();
        }

        private void PrepareFormByLoginUser()
        {
            if (Login.GirisYapmisCalisan != null && Login.GirisYapmisKullanici != null)
            {
                LockForm();
            }

            else if (Login.GirisYapmisCalisan != null)
            {
                _calisanID = Login.GirisYapmisCalisan.CalisanID;
                AraclariListele();
                
            }

            else if (Login.GirisYapmisKullanici != null)
            {
                _kullaniciID = Login.GirisYapmisKullanici.KullaniciID;
                KullaniciAraclariListele();
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

        string secilenMarka;
        string secilenModel;
        string secilenKullaniciTipi;
        string secilenStatu;

        private void AraclariListele()
        {
            lstAracListesi.Items.Clear();
            foreach (AracListVM arac in unitOfWork.AracRepository.AracListele(secilenMarka, secilenModel, secilenKullaniciTipi, secilenStatu))
            {
                ListViewItem li = new ListViewItem();
                li.Text = arac.MarkaAd;
                li.SubItems.Add(arac.ModelAd);
                li.SubItems.Add(arac.KullaniciTip);
                li.SubItems.Add(arac.StatuAd);
                li.SubItems.Add(arac.KullaniciAd);
                li.Tag = arac;
                lstAracListesi.Items.Add(li);
            }            
        }
        private void KullaniciAraclariListele()
        {
            lstAracListesi.Items.Clear();
            foreach (AracListVM arac in unitOfWork.AracRepository.AracListele(_kullaniciID,secilenMarka, secilenModel, secilenKullaniciTipi, secilenStatu))
            {
                ListViewItem li = new ListViewItem();
                li.Text = arac.MarkaAd;
                li.SubItems.Add(arac.ModelAd);
                li.SubItems.Add(arac.KullaniciTip);
                li.SubItems.Add(arac.StatuAd);
                li.SubItems.Add(arac.KullaniciAd);
                li.Tag = arac;
                lstAracListesi.Items.Add(li);
            }
        }

        private void ListModelsByMarka()
        {
            cmbAracModel.Items.Clear();
            cmbAracModel.Items.AddRange(unitOfWork.ArabaModelRepository.ModelListele(cmbAracMarka.SelectedItem as MarkaVM).ToArray());
        }

        private void AracSil()
        {
            var secilenArac = lstAracListesi.SelectedItems[0].Tag as AracListVM;
            if (DialogResult.Yes == MessageBox.Show(string.Format("{0} {1} aracı silinecek! Silmek istediğinize emin misiniz?", secilenArac.MarkaAd, secilenArac.ModelAd), "Araç Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                && DialogResult.Yes == MessageBox.Show(string.Format("{0} {1} aracı silindikten sonra geri alınamaz. Devam etmek istediğinize emin misiniz?", secilenArac.MarkaAd, secilenArac.ModelAd), "Araç Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                && DialogResult.Yes == MessageBox.Show("Son kararınız mı?", "Araç Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (lstAracListesi.SelectedItems.Count > 0)
                {
                    unitOfWork.AracRepository.AracSil(secilenArac.AracID);
                    if (unitOfWork.Complete() > 0)
                    {
                        MessageBox.Show("Araç silindi.");
                        PrepareFormByLoginUser();
                    }
                    else
                    {
                        errorProvider.SetError(btnSil, "Silinemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen listeden bir araç seçiniz.");
                }
            }
        }

        private void FiltreleriTemizle()
        {
            cmbAracModel.SelectedIndex = cmbKullaniciTipi.SelectedIndex = cmbStatu.SelectedIndex = cmbAracMarka.SelectedIndex = -1;
            secilenMarka = secilenModel = secilenKullaniciTipi = secilenStatu = null;
            PrepareFormByLoginUser();

        }

        private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAracMarka.SelectedIndex > -1)
            {
                ListModelsByMarka();
            }

        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAracDetayBilgi aracDetayBilgi = new frmAracDetayBilgi())
            {
                aracDetayBilgi.ShowDialog();
            }
            PrepareFormByLoginUser();
            this.Show();
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            secilenMarka = cmbAracMarka.SelectedItem == null ? null : cmbAracMarka.SelectedItem.ToString();
            secilenModel = cmbAracModel.SelectedItem == null ? null : cmbAracModel.SelectedItem.ToString();
            secilenKullaniciTipi = cmbKullaniciTipi.SelectedItem == null ? null : cmbKullaniciTipi.SelectedItem.ToString();
            secilenStatu = cmbStatu.SelectedItem == null ? null : cmbStatu.SelectedItem.ToString();
            PrepareFormByLoginUser();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FiltreleriTemizle();
        }
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            AracListVM arac = lstAracListesi.SelectedItems[0].Tag as AracListVM;
            using (frmAracDetayBilgi aracDetayBilgi = new frmAracDetayBilgi(arac))
            {
                aracDetayBilgi.ShowDialog();
            }
            btnGuncelle.Enabled = btnSil.Enabled = false;
            PrepareFormByLoginUser();
            this.Show();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            AracSil();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void lstAracListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAracListesi.SelectedItems.Count > 0)
            {
                btnGuncelle.Enabled = btnSil.Enabled = true;
            }
            else
            {
                btnGuncelle.Enabled = btnSil.Enabled = false;
            }
        }
    }
}

