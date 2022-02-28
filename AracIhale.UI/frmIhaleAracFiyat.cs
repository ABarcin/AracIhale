using AracIhale.CORE;
using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmIhaleAracFiyat : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        Validation validation = new Validation();
        IhaleListVM ihaleListVM = null;
        public frmIhaleAracFiyat()
        {
            InitializeComponent();
        }

        public frmIhaleAracFiyat(IhaleListVM _ihaleListVM) : this()
        {
            ihaleListVM = _ihaleListVM;
        }

        private void IhaleAracFiyat_Load(object sender, EventArgs e)
        {
            AracComboBoxDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(ihaleListVM != null)
            {
                if (ValidateForm())
                {
                    DialogResult result = MessageBox.Show("Aracı eklemek istediğinize eminmisiniz", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (unitOfWork.AracRepository.GetAracByIhaleID(ihaleListVM.IhaleID).Count == 0)
                        {
                            IhaleAracVM ihaleAracVM = new IhaleAracVM();
                            ihaleAracVM.AracID = (cmbArac.SelectedItem as AracListVM).AracID;
                            ihaleAracVM.IhaleBaslangicFiyat = decimal.Parse(txtIhaleBaslangicFiyat.Text);
                            ihaleAracVM.MinAlimFiyati = decimal.Parse(txtIhaleBitisFiyat.Text);
                            ihaleAracVM.IhaleID = ihaleListVM.IhaleID;

                            unitOfWork.IhaleAracRepository.Add(new IhaleAracMapping().IhaleAracVMToIhaleArac(ihaleAracVM));
                            unitOfWork.Complete();
                            Clear();

                            MessageBox.Show("Araç ihaleye eklendi.");
                        }

                        else
                        {
                            MessageBox.Show("Eklemek istediğiniz araç zaten bu ihalede bulunmaktadır.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("İhale seçmediniz. Lütfen ihale listeleme ekranından ihale seçiniz.","",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        public bool ValidateForm()
        {
            bool IsValid = true;
            decimal baslangicFiyat = 0.0M;
            decimal bitisFiyat = 0.0M;

            errorProviderIhaleAracFiyat.Clear();

            if (cmbArac.SelectedIndex == 0)
            {
                errorProviderIhaleAracFiyat.SetError(cmbArac, "Bu kısım boş geçilemez");
                IsValid = false;
            }

            if(!validation.IsValidateMoney(txtIhaleBaslangicFiyat, errorProviderIhaleAracFiyat))
            {
                IsValid = false;
            }
            else
            {
                baslangicFiyat = decimal.Parse(txtIhaleBaslangicFiyat.Text);
            }

            if(!validation.IsValidateMoney(txtIhaleBitisFiyat, errorProviderIhaleAracFiyat))
            {
                IsValid = false;
            }
            else
            {
                bitisFiyat = decimal.Parse(txtIhaleBitisFiyat.Text);
            }

            if (baslangicFiyat > bitisFiyat)
            {
                IsValid = false;
                errorProviderIhaleAracFiyat.SetError(txtIhaleBaslangicFiyat, "Başlangıç fiyat bitiş fiyattan büyük olamaz");
                errorProviderIhaleAracFiyat.SetError(txtIhaleBitisFiyat, "Başlangıç fiyat bitiş fiyattan büyük olamaz");
            }

            return IsValid;
        }

        private void AracComboBoxDoldur()
        {
            cmbArac.Items.Add("Araç Seçiniz");
            cmbArac.SelectedIndex = 0;
            cmbArac.Items.AddRange(unitOfWork.AracRepository.AracVMListele().ToArray());
        }

        private void Clear()
        {
            txtIhaleBaslangicFiyat.Text = string.Empty;
            txtIhaleBitisFiyat.Text = string.Empty;
            cmbArac.SelectedIndex = 0;
        }
    }
}
