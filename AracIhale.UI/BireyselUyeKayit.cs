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
    public partial class BireyselUyeKayit : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        Validation validation = new Validation();
        public BireyselUyeKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KullaniciVM kullaniciVM = new KullaniciVM();

            ErrorProvider errorProviderAd = new ErrorProvider();
            ErrorProvider errorProviderSoyad = new ErrorProvider();
            ErrorProvider errorProviderKullaniciAdi = new ErrorProvider();
            ErrorProvider errorProviderSifre = new ErrorProvider();
            ErrorProvider errorProviderSifreTekrar = new ErrorProvider();

            if (cbKvkk.Checked && cbUyelik.Checked)
            {
                if (txtSifre.Text != txtSifreTekrar.Text)
                {
                    errorProviderSifreTekrar.SetError(txtSifreTekrar, "Şifre ile şifre tekarar eşleşmiyor");
                }
                else
                {
                    errorProviderSifreTekrar.Clear();
                }

                if (validation.IsValidateName(txtAd, 1, 100, errorProviderAd) &&
                    validation.IsValidateName(txtSoyad, 1, 100, errorProviderSoyad) &&
                    validation.IsValidateUserName(txtKullaniciAdi, errorProviderKullaniciAdi, 1, 25) &&
                    validation.IsValidatePassword(txtSifre, 1, 50, errorProviderSifre) &&
                    validation.IsValidatePassword(txtSifreTekrar, 1, 50, errorProviderSifre) &&
                    txtSifre.Text == txtSifreTekrar.Text)
                {
                    kullaniciVM.Ad = txtAd.Text;
                    kullaniciVM.Soyad = txtSoyad.Text;
                    kullaniciVM.KullaniciAd = txtKullaniciAdi.Text;
                    kullaniciVM.Sifre = txtSifre.Text;
                    kullaniciVM.RolID = 1;
                    kullaniciVM.KullaniciTipID = 1;
                    kullaniciVM.KVKK = cbKvkk.Checked;

                    unitOfWork.KullaniciRepository.BireyselKullaniciEkle(kullaniciVM);

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
        }
    }
}
