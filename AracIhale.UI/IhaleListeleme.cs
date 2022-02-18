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
        public IhaleListeleme()
        {
            InitializeComponent();
        }
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        private void PrepareForm()
        {
            cmbUyeTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            cmbStatu.Items.AddRange(unitOfWork.IhaleStatuRepository.StatuleriListele().ToArray());
        }
        KullaniciTipVM secilenKullaniciTipi;
        StatuVM secilenStatu;
        private void btnListele_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                secilenKullaniciTipi = cmbUyeTipi.SelectedItem as KullaniciTipVM;
                secilenStatu = cmbStatu.SelectedItem as StatuVM;

                FiltrelenenIhaleleriListele();
            }
        }

        private void FiltrelenenIhaleleriListele()
        {
            listIhaleler.Items.Clear();
            foreach (IhaleListVM ihale in unitOfWork.IhaleRepository.IhaleListele(txtIhaleAdi.Text, secilenKullaniciTipi, secilenStatu))
            {
                ListViewItem li = new ListViewItem();
                li.Text = ihale.IhaleID.ToString();
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

        private bool IsValidate()
        {
            bool isValidate = false;

            if (!string.IsNullOrWhiteSpace(txtIhaleAdi.Text) && cmbUyeTipi.SelectedIndex > -1 && cmbStatu.SelectedIndex > -1)
            {
                isValidate = true;
            }
            return isValidate;
        }
        private void IhaleListeleme_Load(object sender, EventArgs e)
        {
            PrepareForm();

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
