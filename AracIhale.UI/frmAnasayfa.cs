using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.CORE.Mapping;
using AracIhale.CORE.VM;
using AracIhale.DAL.Repositories.Concrete;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }
        UnitOfWork unitOfWork = new UnitOfWork();
        Validation validation;
        private void btnBireysel_Click(object sender, EventArgs e)
        {
            Hide();
            using (frmKullaniciKayit frm = new frmKullaniciKayit())
            {
                frm.ShowDialog();
            }
            Close();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                KullaniciVM kullanici = unitOfWork.KullaniciRepository.KullaniciGetir(txtKullaniciAdi.Text);
                bool loginOlduMu = unitOfWork.KullaniciRepository.OturumAc(txtKullaniciAdi.Text, txtSifre.Text);
                if (loginOlduMu)
                {
                    Login.GirisYapmisKullanici = kullanici;
                    Login.SayfaYetkiYonetimiListesi = new LoginRepository().
                        HerSayfaIcınYetkiVMDoldur(new RolMapping().RolToRolVM(unitOfWork.RolRepository.GetByID(kullanici.RolID)));
                    Hide();
                    using (frmKullaniciAnasayfa frm = new frmKullaniciAnasayfa())
                    {
                        frm.ShowDialog();
                    }
                    Close();
                    errorProvider.Clear();
                }
                else
                {
                    errorProvider.SetError(btnGiris, "Hatalı Kullanıcı Adı Yada Şifre!!!");
                }
            }
            else
            {
                errorProvider.SetError(btnGiris, "Girdiğiniz Bilgiler Eksik Yada Hatalı");
            }

        }
        private bool IsValidate()
        {
            validation = new Validation();
            bool validate = false;
            if (validation.IsValidateUserName(txtKullaniciAdi, errorProvider, 3, 25) && validation.IsValidatePassword(txtSifre, 3, 50, errorProvider))
            {
                validate = true;
            }
            return validate;
        }
        private void btnSifre_Click(object sender, EventArgs e)
        {
            Hide();
            using (frmSifreBul frmSifre = new frmSifreBul(Text))
            {
                frmSifre.ShowDialog();
            }
            Close();
        }
    }
}
