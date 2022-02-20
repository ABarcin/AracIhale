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
    public partial class frmIhaleListeleme : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());

        IhaleListVM ihaleListVM = null;

        public frmIhaleListeleme()
        {
            InitializeComponent();
        }

        private void IhaleListeleme_Load(object sender, EventArgs e)
        {
            PrepareForm();
            SetDefaultValueAndFillListView();
            btnGuncelle.Enabled = false;
        }

        /// <summary>
        /// Comboboxlarin dolduruldugu metod.
        /// </summary>
        private void PrepareForm()
        {
            cmbUyeTipi.Items.Add("Uye Tipi Seciniz");
            cmbUyeTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            
            cmbStatu.Items.Add("Statu Seciniz");
            cmbStatu.Items.AddRange(unitOfWork.IhaleStatuRepository.StatuleriListele().ToArray());

            cmbUyeTipi.SelectedIndex = 0;
            cmbStatu.SelectedIndex = 0;

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

            List<IhaleListVM> ihaleListVMs = new List<IhaleListVM>();

            IhaleListVM ihale1 = new IhaleListVM() {
                IhaleID = 1,
                IhaleAdi = "Gel vatandas gel passat var",
                KullaniciTipID = 1,
                CalisanID = 1,
                KullaniciTip = "Kurumsal",
                IhaleBaslangic = DateTime.Now,
                IhaleBitis = DateTime.Now,
                BaslangicSaat = TimeSpan.Zero,
                BitisSaat = TimeSpan.Zero,
                IhaleStatuID = 1,
                IhaleDurum = "Basladi",
                KullaniciAd = "JagatayBaba"
            };

            IhaleListVM ihale2 = new IhaleListVM()
            {
                IhaleID = 2,
                IhaleAdi = "Sıfır hasar mercedes",
                KullaniciTipID = 2,
                CalisanID = 1,
                KullaniciTip = "Bireysel",
                IhaleBaslangic = DateTime.Now,
                IhaleBitis = DateTime.Now,
                BaslangicSaat = TimeSpan.Zero,
                BitisSaat = TimeSpan.Zero,
                IhaleStatuID = 2,
                IhaleDurum = "Bitti",
                KullaniciAd = "BurakBaba"
            };

            IhaleListVM ihale3 = new IhaleListVM()
            {
                IhaleID = 3,
                IhaleAdi = "Tank gibi volvo param olsada ben alsam",
                KullaniciTipID = 2,
                CalisanID = 1,
                KullaniciTip = "Bireysel",
                IhaleBaslangic = DateTime.Now,
                IhaleBitis = DateTime.Now,
                BaslangicSaat = TimeSpan.Zero,
                BitisSaat = TimeSpan.Zero,
                IhaleStatuID = 1,
                IhaleDurum = "Basladi",
                KullaniciAd = "FatihSultanMehmet"
            };

            IhaleListVM ihale4 = new IhaleListVM()
            {
                IhaleID = 4,
                IhaleAdi = "Cirrrlop gibi BMW",
                KullaniciTipID = 1,
                CalisanID = 1,
                KullaniciTip = "Kurumsal",
                IhaleBaslangic = DateTime.Now,
                IhaleBitis = DateTime.Now,
                BaslangicSaat = TimeSpan.Zero,
                BitisSaat = TimeSpan.Zero,
                IhaleStatuID = 1,
                IhaleDurum = "Basladi",
                KullaniciAd = "AhmetBarcinn"
            };

            ihaleListVMs.Add(ihale1);
            ihaleListVMs.Add(ihale2);
            ihaleListVMs.Add(ihale3);
            ihaleListVMs.Add(ihale4);

            //FiltrelenenIhaleleriListele(unitOfWork.IhaleRepository.IhaleListele(ihaleAdi, kullaniciTip, statu));
            FiltrelenenIhaleleriListele(ihaleListVMs);
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

        private void listIhaleler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listIhaleler.SelectedItems.Count > 0)
            {
                ihaleListVM = listIhaleler.SelectedItems[0].Tag as IhaleListVM;

                if(ihaleListVM != null)
                {
                    btnGuncelle.Enabled = true;
                }

                MessageBox.Show($"'{ihaleListVM.IhaleAdi}' adlı ihale seçildi.");
            }
        }
    }
}
