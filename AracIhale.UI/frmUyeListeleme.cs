using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmUyeListeleme : Form
    {
        public frmUyeListeleme()
        {
            InitializeComponent();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (listUyeler.SelectedItems.Count>0&&(listUyeler.SelectedItems[0].Tag as KullaniciVM).KullaniciTipID==2)
            {
                this.Hide();
                using (frmUyeOnay uyeOnay=new frmUyeOnay(listUyeler.SelectedItems[0].Tag as KullaniciVM))
                {
                    uyeOnay.ShowDialog();
                }
                this.Show();
            }
            else
            {
                errorProvider.SetError(btnDetay, "Bireysel Kullanicilar İçin Detay Sayfasına Gidilemez");
            }
        }

        private void frmUyeListeleme_Load(object sender, EventArgs e)
        {
            foreach (KullaniciVM item in new UnitOfWork().KullaniciRepository.TumKullanicilariGetir())
            {
                if (item.KullaniciTipID==2)
                {
                    foreach (var kurumsalKullanici in new UnitOfWork().KurumsalKullaniciRepository.KurumsalKullanicilariGetir())
                    {
                        if (kurumsalKullanici.KullaniciID==item.KullaniciID)
                        {
                            string[] row = { item.KullaniciAd, item.Ad, item.Soyad, kurumsalKullanici.OnayDurum.ToString(), kurumsalKullanici.FirmaID.ToString() };
                            var satir = new ListViewItem(row);
                            satir.Tag = item;
                            listUyeler.Items.Add(satir);
                            break;
                        }
                    }
                }
                else
                {
                    string[] row = { item.KullaniciAd, item.Ad, item.Soyad, " ", " " };
                    var satir = new ListViewItem(row);
                    satir.Tag = item;
                    listUyeler.Items.Add(satir);
                }
                
            }
        }
    }
}
