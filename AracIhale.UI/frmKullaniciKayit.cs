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
using AracIhale.DAL.Repositories.Concrete;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;

namespace AracIhale.UI
{
    public partial class frmKullaniciKayit : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        Validation validation = new Validation();
        KullaniciVM kullaniciVM = new KullaniciVM();
        KurumsalKullaniciVM kurumsalKullaniciVM = new KurumsalKullaniciVM();
        FirmaVM firmaVM = new FirmaVM();
        FirmaTipVM firmaTipVM = new FirmaTipVM();
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {


            if (cbKvkk.Checked && cbUyelik.Checked)
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    errorProvider.SetError(txtSifreTekrar, "Şifre ile şifre tekrar eşleşmiyor");
                }
                else
                {
                    errorProvider.Clear();
                }

                if (validation.IsValidateName(txtAd, 1, 100, errorProvider) &&
                    validation.IsValidateName(txtSoyad, 1, 100, errorProvider) &&
                    validation.IsValidateUserName(txtKullaniciAdi, errorProvider, 1, 25) &&
                    validation.IsValidatePassword(txtSifre, 1, 50, errorProvider) &&
                    validation.IsValidatePassword(txtSifreTekrar, 1, 50, errorProvider) &&
                    txtSifre.Text == txtSifreTekrar.Text)
                {
                    kullaniciVM.Ad = txtAd.Text;
                    kullaniciVM.Soyad = txtSoyad.Text;
                    kullaniciVM.KullaniciAd = txtKullaniciAdi.Text;
                    kullaniciVM.Sifre = txtSifre.Text;
                    kullaniciVM.RolID = 1;      //düzeltilmesi lazım
                    kullaniciVM.KullaniciTipID = 1;
                    kullaniciVM.KVKK = cbKvkk.Checked;

                    unitOfWork.KullaniciRepository.BireyselKullaniciEkle(kullaniciVM);
                    unitOfWork.Complate();

                    //burcin
                    if (validation.IsValidateNull(gbFirma,errorProvider))
                    {
                        kurumsalKullaniciVM.KullaniciID = unitOfWork.KullaniciRepository.GetAll(x => x.KullaniciAd == kullaniciVM.KullaniciAd)[0].KullaniciID;

                        kurumsalKullaniciVM.OnayDurum = false;

                        kurumsalKullaniciVM.FirmaID = unitOfWork.FirmaRepository.GetAll()[cmbFirmaAd.SelectedIndex].FirmaID;

                        unitOfWork.KurumsalKullaniciRepository.KurumsalKullaniciEkle(kurumsalKullaniciVM);
                    }
                    

                    if (unitOfWork.Complate() > 0)
                    {
                        MessageBox.Show("Kullanici ekleme başarılı");
                        FormTemizle();
                    }
                    else
                    {
                        MessageBox.Show("Kullanici ekleme başarısız");
                    }
                }
            }

            else
            {
                MessageBox.Show("Lütfen kullanıcı verileri koruma kanunu ve üyelik sözleşmesini kabul ediniz.");
            }
        }

        private void FormTemizle()
        {
            txtAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtSifreTekrar.Text = string.Empty;
            cbKvkk.Checked = false;
            cbUyelik.Checked = false;
            cmbKullaniciTip.Text = string.Empty;
            cmbFirmaTip.Text = string.Empty;
            cmbFirmaAd.Text = string.Empty;
        }

        private void frmKullaniciKayit_Load(object sender, EventArgs e)
        {
            KullaniciTipDoldur();
            FirmaAdDoldur();
            FirmaTipDoldur();
        }

        FirmaTipRepository firmaTipRepo;
        private void FirmaTipDoldur()
        {
            firmaTipRepo = new FirmaTipRepository(new AracIhaleEntities());
            foreach (FirmaTipVM item in firmaTipRepo.GetFirmaTip())
            {
                cmbFirmaTip.Items.Add(item);
            }
        }

        FirmaRepository firmaRepo;
        private void FirmaAdDoldur()
        {
            firmaRepo = new FirmaRepository(new AracIhaleEntities());
            foreach (FirmaVM item in firmaRepo.GetFirmaAd())
            {
                cmbFirmaAd.Items.Add(item);
            }
        }

        KullaniciRepository kullaniciTipRepo;

        private void KullaniciTipDoldur()
        {
            kullaniciTipRepo = new KullaniciRepository(new AracIhaleEntities());
            foreach (KullaniciTipVM item in kullaniciTipRepo.GetKullaniciTip())
            {
                cmbKullaniciTip.Items.Add(item);
            }
        }

        private void cmbKullaniciTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKullaniciTip.Text == "Kurumsal")
            {
                gbFirma.Visible = true;
            }
            else
            {
                gbFirma.Visible = false;
            }
        }
    }
}
