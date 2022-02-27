using AracIhale.CORE;
using AracIhale.DAL.Repositories.Concrete;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Mapping;
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
    public partial class frmBireyselTeklif : Form
    {
        public frmBireyselTeklif()
        {
            InitializeComponent();
        }
        //validasyonlar
        //bilgileri doldur
        //aracteklif entitiy insert at 

        UnitOfWork unitOfWork = new UnitOfWork();
        Validation validation = new Validation();
        int aracID, kullaniciID;
        string adSoyad="Burçin Eren";

        public frmBireyselTeklif(AracCDListVM arac)
        {
                aracID = arac.AracID;
                //aracID = 1035;
                kullaniciID = arac.KullaniciID;
                adSoyad = arac.Kullanici.Ad + " " + arac.Kullanici.Soyad;            
        }

        private void frmBireyselTeklif_Load(object sender, EventArgs e)
        {
            PrepareForm();
            btnTarih.Enabled = btnTramer.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AracTeklifAdd();
        }

        private void AracTeklifAdd()
        {
            if (!txtTeklifFiyat.Text.Equals(""))
            {
                AracTeklifVM aracTeklifVM = new AracTeklifVM();
                aracTeklifVM.IhaleAracID = unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).IhaleAracID;
                aracTeklifVM.KullaniciID = kullaniciID;
                aracTeklifVM.TeklifFiyat = decimal.Parse(txtTeklifFiyat.Text);
                aracTeklifVM.Tarih = DateTime.Now;

                //aracTeklifVM.TeklifOnay yok?

                unitOfWork.AracTeklifRepository.AracTeklifEkle(aracTeklifVM);
                unitOfWork.Complete();
            }
            else
            {
                MessageBox.Show("Teklif verilemedi");
            }
        }

        private void PrepareForm()
        {
            txtAdSoyad.Text = adSoyad;
            cmbMarka.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).MarkaAd);
            cmbMarka.Text = unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).MarkaAd;
            cmbGovde.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).GovdeAd);
            cmbYakit.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).YakıtAd);
            cmbModel.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).ModelAd);
            cmbRenk.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).RenkAd);
            cmbVersiyon.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).Versiyon);
            cmbVites.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).VitesAd);
            cmbYıl.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).Yil);
            cmbDonanim.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).DonanımAd);
            cmbStatu.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).StatuAd);
            nmKM.Value = unitOfWork.IhaleAracRepository.IhaleAracFindByID(aracID).Km;
            cmbStatu.SelectedIndex = 0;

            foreach (Control item in gbAracDetay.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cmb = item as ComboBox;

                    cmb.SelectedIndex = 0;
                }

            }
        }
    }
}
