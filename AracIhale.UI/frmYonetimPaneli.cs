using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.Model.Entities;
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
    public partial class frmYonetimPaneli : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        public frmYonetimPaneli()
        {
            InitializeComponent();
        }

        Validation validation;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                CalisanVM calisan = unitOfWork.CalisanRepository.KullaniciGetir(txtKullaniciAdi.Text);
                if (YetkiKontrol(calisan))
                {
                    bool loginOlduMu = unitOfWork.CalisanRepository.OturumAc(txtKullaniciAdi.Text, txtSifre.Text);

                    if (loginOlduMu)
                    {
                        LoginKullanici.GirisYapmisCalisan = calisan;
                        this.Hide();
                        using (frmAdminAnasayfa adminAnasayfa = new frmAdminAnasayfa())
                        {
                            adminAnasayfa.ShowDialog();
                        }
                        this.Close();
                        errorProvider.Clear();
                    }
                    else
                    {
                        errorProvider.SetError(btnGiris, "Hatalı Kullanıcı Adı Yada Şifre!!!");
                    }
                }
                
                else
                {
                    errorProvider.SetError(btnGiris, "Bu Sayfa İçin Gerekli Yetkiniz Yok");
                }
            }
            else
            {
                errorProvider.SetError(btnGiris, "Girdiğiniz Bilgiler Eksik Yada Hatalı");

            }
        }
        /// <summary>
        /// fomrdan gelen bilgiler kontrol ediliyor
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        ///Kullanıcı için SüperAdmin=1 Admin=2 olarak kontrol ediliyor admin olmayanlar sayfaya giriş yapamayacak.
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        private bool YetkiKontrol(CalisanVM vm)
        {
            bool validate = false;
            if (vm.RolID == 1 || vm.RolID == 2)
            {
                validate = true;
            }
            return validate;
        }
        /// <summary>
        /// şifresini unutan çalışanlar için mail ile şifre alma
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSifre_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmSifreBul frmSifre = new frmSifreBul())
            {
                frmSifre.ShowDialog();
            }
            this.Close();
        }

        private void frmYonetimPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
