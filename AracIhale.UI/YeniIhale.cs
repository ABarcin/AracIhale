using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracIhale.CORE;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;

namespace AracIhale.UI
{
    public partial class YeniIhale : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        Validation validation = new Validation();

        public YeniIhale()
        {
            InitializeComponent();
        }

        private void YeniIhale_Load(object sender, EventArgs e)
        {
            KullaniciTipComboBoxDoldur();
            IhaleStatuComboBoxDoldur();
            FirmaComboBoxDoldu();
            DateTimePickerDoldur();
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AracListViewDoldur();
        }
        private void DateTimePickerDoldur()
        {
            dtIhaleBaslangic.Value = DateTime.Now;
            dtIhaleBitis.Value = DateTime.Now;
        }

        private void AracListViewDoldur()
        {
            if (!validation.IsValidateNull(gbIhaleGenel, errorProvider1, dtIhaleBaslangic, dtIhaleBitis, dtBaslangicSaat, dtBitisSaat))
            {
                List<AracCDListVM> aracListVMler = unitOfWork.AracRepository.GetAracByIhaleID(1);

                foreach (var item in aracListVMler)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.AracID.ToString();
                    listViewItem.SubItems.Add(item.Marka.Ad);
                    listViewItem.SubItems.Add(item.ArabaModel.Ad);
                    listViewItem.SubItems.Add(item.Kullanici.KullaniciTip.Tip);

                    //listArac.Items.Add(listViewItem);
                }
            }
        }

        private void KullaniciTipComboBoxDoldur()
        {
            cmbUyeTip.Items.Add("Tip seçiniz");
            cmbUyeTip.SelectedIndex = 0;

            List<KullaniciTipVM> kullaniciTipVMler = unitOfWork.KullaniciTipRepository.GetKullaniciTipVM();

            cmbUyeTip.Items.AddRange(kullaniciTipVMler.ToArray());
        }

        private void IhaleStatuComboBoxDoldur()
        {
            cmbStatu.Items.Add("Statu seçiniz");
            cmbStatu.SelectedIndex = 0;

            List<IhaleStatuVM> ihaleStatuVMler = unitOfWork.IhaleStatuRepository.GetIhaleStatuVM();

            cmbStatu.Items.AddRange(ihaleStatuVMler.ToArray());

        }

        private void FirmaComboBoxDoldu()
        {
            cmbSirketAdi.Items.Add("Şirket seçiniz");
            cmbSirketAdi.SelectedIndex = 0;

            List<FirmaVM> firmaVMler = unitOfWork.FirmaRepository.GetFirmaVMler();

            cmbSirketAdi.Items.AddRange(firmaVMler.ToArray());
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (IhaleAracFiyat ihaleAracFiyat=new IhaleAracFiyat())
            {
                ihaleAracFiyat.ShowDialog();
            }
            this.Show();
        }
    }
}
