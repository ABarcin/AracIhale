using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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
        UnitOfWork unitOfWork = new UnitOfWork();
        Validation validation = new Validation();
        KullaniciVM kullaniciVM = new KullaniciVM();
        KullaniciTipVM kullaniciTipVM = new KullaniciTipVM();
        KurumsalKullaniciVM kurumsalKullaniciVM = new KurumsalKullaniciVM();
        FirmaVM firmaVM = new FirmaVM();
        FirmaTipVM firmaTipVM = new FirmaTipVM();
        RolVM rolVM = new RolVM();

        public frmKullaniciKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope trans = new TransactionScope())
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
                            //düzeltilmesi lazım
                            kullaniciVM.RolID = unitOfWork.RolRepository.RolIDGetir(cmbKullaniciTip.SelectedItem.ToString());
                            kullaniciVM.KullaniciTipID = 1;
                            kullaniciVM.KVKK = cbKvkk.Checked;

                            unitOfWork.KullaniciRepository.BireyselKullaniciEkle(kullaniciVM);
                            unitOfWork.Complete();

                            //burcin
                            if (cmbKullaniciTip.Text == "Kurumsal")
                            {
                                kurumsalKullaniciVM.KullaniciID = unitOfWork.KullaniciRepository.GetAll(x => x.KullaniciAd == kullaniciVM.KullaniciAd)[0].KullaniciID;

                                kurumsalKullaniciVM.OnayDurum = false;

                                kurumsalKullaniciVM.FirmaID = unitOfWork.FirmaRepository.GetAll()[cmbFirmaAd.SelectedIndex].FirmaID;

                                unitOfWork.KurumsalKullaniciRepository.KurumsalKullaniciEkle(kurumsalKullaniciVM);
                            }

                        }
                        trans.Complete();
                        FormTemizle();
                        MessageBox.Show("Kayıt yapıldı.");
                    }
                    else
                    {
                        MessageBox.Show("Lütfen kullanıcı verileri koruma kanunu ve üyelik sözleşmesini kabul ediniz.");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kayıt yapılamadı.");
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

        private void sozlesmeMetni_Click(object sender, EventArgs e)
        {
            string message = "Madde 1. Taraflar İşbu sözleşme bir sonraki maddede detayı yer alan ………………………………… plakalı aracın ……………………….\n " +
                "TC Kimlik Numaralı / Vergi numaralı sahibi(SATICI) tarafından ……………………………….\n" +
                " TC.Kimlik Numaralı / Vergi numaralı(ALICI) alıcısına satışına ilişkindir.Madde 2:\n" +
                " Araç Kimlik Bilgileri Plaka  :\n" +
                "Cinsi:\n" +
                "Markası ve tipi:\n" +
                "Modeli:\n" +
                "Rengi:\n" +
                "Motor No:\n" +
                "Şase No:\n" +
                "Ruhsat sahibi:";
            string title = "Sozlesme Metni";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                cbUyelik.Checked =true;
            }
            else
            {
                cbUyelik.Checked = false;
            }
        }

        private void kvkkMetni_Click(object sender, EventArgs e)
        {
            string message = "KVKK METNİ";
            string title = "KVKK METNİ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                cbKvkk.Checked = true;
            }
            else
            {
                cbKvkk.Checked = false;
            }
        }
    }
}