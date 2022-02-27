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
            if (validation.IsValidateNull(gbGenelBilgiler, errorProvider1))
            {
                AracTeklifVM aracTeklifVM = new AracTeklifVM();
                //kullanıcıid gelecek ve ihalearacıd gelecek
                aracTeklifVM.IhaleAracID = 1035;
                aracTeklifVM.KullaniciID = 1;
                aracTeklifVM.TeklifFiyat = decimal.Parse(txtTeklifFiyat.Text);
                aracTeklifVM.Tarih = DateTime.Now;

                //aracTeklifVM.TeklifOnay yok?

                unitOfWork.AracTeklifRepository.AracTeklifEkle(aracTeklifVM);
                unitOfWork.Complete();
            }
            else
            {
                MessageBox.Show("Teklif verilmedi");
            }
        }

        private void PrepareForm()
        {
            int id = 1035;

            cmbMarka.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).MarkaAd);
            cmbMarka.Text = unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).MarkaAd;
            cmbGovde.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).GovdeAd);
            cmbYakit.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).YakıtAd);
            cmbModel.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).ModelAd);
            cmbRenk.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).RenkAd);
            cmbVersiyon.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).Versiyon);
            cmbVites.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).VitesAd);
            cmbYıl.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).Yil);
            cmbDonanim.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).DonanımAd);
            cmbStatu.Items.Add(unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).StatuAd);
            nmKM.Value = unitOfWork.IhaleAracRepository.IhaleAracFindByID(id).Km;
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
