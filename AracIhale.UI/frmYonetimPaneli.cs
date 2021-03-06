using AracIhale.CORE;
using AracIhale.CORE.Encryption;
using AracIhale.CORE.Login;
using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Concrete;
using AracIhale.DAL.UnitOfWork;
using System;
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
                        Login.GirisYapmisCalisan = calisan;
                        Login.SayfaYetkiYonetimiListesi = new LoginRepository().
                            HerSayfaIcınYetkiVMDoldur(new RolMapping().RolToRolVM(unitOfWork.RolRepository.GetByID(calisan.RolID)));
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
            using (frmSifreBul frmSifre = new frmSifreBul(Text))
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
