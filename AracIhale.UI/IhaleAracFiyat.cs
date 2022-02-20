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
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;

namespace AracIhale.UI
{
    public partial class IhaleAracFiyat : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        Validation validation = new Validation();
        IhaleListVM ihaleListVM = null;
        public IhaleAracFiyat()
        {
            InitializeComponent();
        }

        public IhaleAracFiyat(IhaleListVM _ihaleListVM) : this()
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
                        IhaleAracVM ihaleAracVM = new IhaleAracVM();
                        ihaleAracVM.AracID = (cmbArac.SelectedItem as AracListVM).AracID;
                        ihaleAracVM.IhaleBaslangicFiyat = decimal.Parse(txtIhaleBaslangicFiyat.Text);
                        ihaleAracVM.MinAlimFiyati = decimal.Parse(txtIhaleBitisFiyat.Text);
                        ihaleAracVM.IhaleID = ihaleListVM.IhaleID;

                        unitOfWork.IhaleAracRepository.Add(new IhaleAracMapping().IhaleAracVMToIhaleArac(ihaleAracVM));
                        unitOfWork.Complate();
                        Clear();
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
