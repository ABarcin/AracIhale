using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Transactions;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmUyeOnay : Form
    {
        public frmUyeOnay(KullaniciVM kullaniciVM)
        {
            kullanici = kullaniciVM;
            InitializeComponent();
        }
        KullaniciVM kullanici = new KullaniciVM();
        KurumsalKullaniciVM kurumsalKullanici = new KurumsalKullaniciVM();
        FirmaVM firma;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbPaket.SelectedIndex!=-1)
            {
                using (TransactionScope scope=new TransactionScope())
                {
                    try
                    {
                        if (chkOnay.Checked==true)
                        {
                            kurumsalKullanici.OnayDurum = true;
                        }
                        else
                        {
                            kurumsalKullanici.OnayDurum = false;
                        }
                        firma.PaketID = (cmbPaket.SelectedItem as PaketVM).PaketID;
                        new UnitOfWork().KurumsalKullaniciRepository.KurumsalKullaniciGuncelle(kurumsalKullanici);
                        new UnitOfWork().FirmaRepository.FirmaGuncelle(firma); 
                        int value = new UnitOfWork().Complete();
                        if (value > 0)
                        {
                            MessageBox.Show("Onay Verildi");
                        }
                        scope.Complete();
                    }
                    catch (Exception)
                    {
                        errorProvider.SetError(btnKaydet, "Veri Tabanı Hatası");
                    }
                }
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(btnKaydet, "Paket Seçmediniz Yada Onay Vermediniz");
            }
        }

        private void frmUyeOnay_Load(object sender, EventArgs e)
        {
            txtKullaniciAd.Text = kullanici.KullaniciAd;
            txtAd.Text = kullanici.Ad;
            txtSoyad.Text = kullanici.Soyad;
            bool bulundumu = false;
            foreach (var item in new UnitOfWork().FirmaRepository.GetFirmaVMler())
            {
                if (bulundumu)
                {
                    break;
                }
                foreach (var kurumsal in new UnitOfWork().KurumsalKullaniciRepository.KurumsalKullanicilariGetir())
                {
                    if (kullanici.KullaniciID== kurumsal.KullaniciID&& kurumsal.FirmaID==item.FirmaID)
                    {
                        firma = item;
                        kurumsalKullanici = kurumsal;
                        txtFirmaAd.Text = item.Unvan;
                        bulundumu = true;
                        break;
                    }
                }
                
            }
            foreach (var item in cmbPaket.Items)
            {
                if (item.ToString()==firma.Unvan)
                {
                    cmbPaket.SelectedItem = item;
                }
            }
            if (kurumsalKullanici.OnayDurum==true)
            {
                chkOnay.Checked = true;
            }
            else
            {
                chkOnay.Checked = false; ;
            }
            foreach (var item in new UnitOfWork().PaketRepository.TumPaketler())
            {
                cmbPaket.Items.Add(item);
            }

        }
    }
}
