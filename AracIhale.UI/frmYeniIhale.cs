using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;

namespace AracIhale.UI
{
    public partial class frmYeniIhale : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        IhaleListVM ihaleListVM = null;

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
            KullaniciTipComboBoxDoldur();
            IhaleStatuComboBoxDoldur();
            FirmaComboBoxDoldu();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(ihaleListVM == null)
            {
                // Validation yapilacak
                // EKLE
                ihaleListVM.IhaleAdi = txtIhaleAdi.Text;
                ihaleListVM.KullaniciTipID = (cmbUyeTip.SelectedItem as KullaniciTipVM).KullaniciTipID;
                //ihaleListVM.KullaniciTip = (cmbUyeTip.SelectedItem as KullaniciTipVM).Tip;
                ihaleListVM.IhaleBaslangic = dtBaslangicSaat.Value;
                ihaleListVM.IhaleBitis = dtIhaleBitis.Value;
                ihaleListVM.BaslangicSaat = dtIhaleBaslangic.Value.TimeOfDay;
                ihaleListVM.BitisSaat = dtBitisSaat.Value.TimeOfDay;
                ihaleListVM.IhaleStatuID = (cmbStatu.SelectedItem as IhaleStatuVM).IhaleStatuID;
                //ihaleListVM.IhaleDurum = (cmbStatu.SelectedItem as IhaleStatuVM).Durum;
                ihaleListVM.CalisanID = 1;

                unitOfWork.IhaleRepository.InsertIhaleVM(ihaleListVM);

                if(unitOfWork.Complate() > 0)
                {
                    MessageBox.Show("İhale ekleme başarılı");
                }
                else
                {
                    MessageBox.Show("İhale ekleme başarısız");
                }

            }
            else
            {
                // Validation yapilacak
                // GUNCELLE

                ihaleListVM.IhaleAdi = txtIhaleAdi.Text;
                ihaleListVM.KullaniciTipID = (cmbUyeTip.SelectedItem as KullaniciTipVM).KullaniciTipID;
                ihaleListVM.IhaleBaslangic = dtBaslangicSaat.Value;
                ihaleListVM.IhaleBitis = dtIhaleBitis.Value;
                ihaleListVM.BaslangicSaat = dtIhaleBaslangic.Value.TimeOfDay;
                ihaleListVM.BitisSaat = dtBitisSaat.Value.TimeOfDay;
                ihaleListVM.IhaleStatuID = (cmbStatu.SelectedItem as IhaleStatuVM).IhaleStatuID;

                unitOfWork.IhaleRepository.UpdateIhaleVM(ihaleListVM);

                if (unitOfWork.Complate() > 0)
                {
                    MessageBox.Show("İhale güncelleme başarılı");
                }
                else
                {
                    MessageBox.Show("İhale güncelleme başarısız");
                }
            }

        }

        private void AracListViewDoldur()
        {
            List<AracCDListVM> aracListVMler = unitOfWork.AracRepository.GetAracByIhaleID(ihaleListVM.IhaleID);

            foreach (var item in aracListVMler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.AracID.ToString();
                listViewItem.SubItems.Add(item.Marka.Ad);
                listViewItem.SubItems.Add(item.ArabaModel.Ad);
                listViewItem.SubItems.Add(item.Kullanici.KullaniciTip.Tip);

                listArac.Items.Add(listViewItem);
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
            using (frmIhaleAracFiyat ihaleAracFiyat=new frmIhaleAracFiyat(ihaleListVM))
            {
                ihaleAracFiyat.ShowDialog();
            }
            this.Show();
        }
    }
}
