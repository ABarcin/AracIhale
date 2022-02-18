using AracIhale.CORE;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
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
    public partial class YonetimPaneli : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());

        public YonetimPaneli()
        {
            InitializeComponent();
        }

        Validation validation;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                bool loginOlduMu = unitOfWork.CalisanRepository.OturumAc(txtKullaniciAdi.Text, txtSifre.Text);

                if (loginOlduMu)
                {
                    this.Hide();
                    using (AdminAnasayfa adminAnasayfa=new AdminAnasayfa())
                    {
                        adminAnasayfa.ShowDialog();
                    }
                    this.Close();
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(btnGiris, "Hatalı Kullanıcı Adı Yada Şifre");
                }
            }
        }
        private bool IsValidate()
        {
            validation = new Validation();
            bool validate = false;
            if (validation.IsValidateUserName(txtKullaniciAdi,errorProvider,3,25)&&validation.IsValidatePassword(txtSifre,3,50,errorProvider))
            {
                validate = true;
            }
            return validate;
        }

        private void YonetimPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
