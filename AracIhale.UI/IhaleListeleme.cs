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
    public partial class IhaleListeleme : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());

        public IhaleListeleme()
        {
            InitializeComponent();
        }

        private void IhaleListeleme_Load(object sender, EventArgs e)
        {
            PrepareForm();
            SetDefaultValueAndFillListView();
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
            using (YeniIhale yeniIhale=new YeniIhale())
            {
                yeniIhale.ShowDialog();
            }
            this.Show();
        }
    }
}
