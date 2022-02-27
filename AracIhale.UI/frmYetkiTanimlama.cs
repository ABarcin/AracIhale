using AracIhale.CORE.Login;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;
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

namespace AracIhale.UI
{
    public partial class frmYetkiTanimlama : Form
    {
        UnitOfWork _unitOfWork = new UnitOfWork();
        List<RolVM> _rolListesi;
        List<SayfaVM> _sayfaListesi;
        List<YetkiVM> _yetkiListesi;

        public frmYetkiTanimlama()
        {
            InitializeComponent();
        }

        private void frmYetkiTanimlama_Load(object sender, EventArgs e)
        {
            PrepareForm(); 
            PrepareFormByLoggedUser();
        }

        private void PrepareForm()
        {
            _rolListesi = _unitOfWork.RolRepository.TumRoller();
            _sayfaListesi = _unitOfWork.SayfaRepository.TumSayfalar();
            _yetkiListesi = _unitOfWork.YetkiRepository.TumYetkiler();

            foreach (var rol in _rolListesi)
            {
                cmbRoller.Items.Add(rol);
            }

            foreach (var sayfa in _sayfaListesi)
            {
                cmbSayfalar.Items.Add(sayfa);
            }

            foreach (var yetki in _yetkiListesi)
            {
                Label lblYetki = new Label
                {
                    Text = yetki.YetkiAciklama,
                    Anchor = AnchorStyles.Bottom
                };

                flpYetkiler.Controls.Add(lblYetki);

                CheckBox cbYetki = new CheckBox
                {
                    Name = yetki.YetkiID.ToString(),
                };

                flpYetkiler.Controls.Add(cbYetki);
            }
        }

        private void PrepareFormByLoggedUser()
        {
            if (Login.GirisYapmisCalisan == null)
            {
                LockForm();
            }
            else
            {
                RolYetkiKontrol();
            }
        }

        private void RolYetkiKontrol()
        {
            var rolYetki = Login.SayfaYetkiYonetimiListesi.FirstOrDefault(x => x.Sayfa.SayfaAdi == this.Name);

            if (rolYetki.YetkiListesi.Count > 0)
            {
                if (rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Read"))
                {

                    bool update = rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Update");

                    if (!update)
                    {
                        btnGuncelle.Visible = false;
                    }
                    else
                    {
                        LockForm();
                    }
                }
                else
                {
                    LockForm();
                }
            }
        }

        private void LockForm()
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Enabled = false;
            }
        }

        private void RolYetkiDoldur(List<RolYetkiVM> lst)
        {
            foreach (var control in flpYetkiler.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = false;

                    foreach (var yetkiVM in _yetkiListesi)
                    {
                        foreach (var item in lst)
                        {
                            if (checkBox.Name == item.YetkiID.ToString())
                            {
                                checkBox.Checked = true;
                            }
                        }
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    RolVM rolVM = null;
                    SayfaVM sayfaVM = null;

                    if (cmbRoller.SelectedIndex != -1)
                    {
                        rolVM = cmbRoller.SelectedItem as RolVM;
                    }

                    if (cmbSayfalar.SelectedIndex != -1)
                    {
                        sayfaVM = cmbSayfalar.SelectedItem as SayfaVM;
                    }

                    if (rolVM != null && sayfaVM != null)
                    {
                        _unitOfWork.RolYetkiRepository.RolYetkiSoftDelete(rolVM, sayfaVM);
                        _unitOfWork.Complete();

                        foreach (var control in flpYetkiler.Controls)
                        {
                            if (control.GetType() == typeof(CheckBox))
                            {
                                CheckBox checkBox = control as CheckBox;

                                foreach (var yetkiVM in _yetkiListesi)
                                {
                                    if (checkBox.Checked && checkBox.Name == yetkiVM.YetkiID.ToString())
                                    {
                                        _unitOfWork.RolYetkiRepository.RolYetkiEkle(rolVM, sayfaVM, yetkiVM);
                                        _unitOfWork.Complete();
                                    }
                                }
                            }
                        }
                    }

                    scope.Complete();
                    MessageBox.Show($"{rolVM.Ad} rolüne, {sayfaVM.SayfaAdi} formunda, seçilen yetkiler atanmıştır.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Yetki ataması yapılamadı.");
                }

            }
        }

        private void cmbRoller_SelectedIndexChanged(object sender, EventArgs e)
        {
            RolVM rolVM = null;
            SayfaVM sayfaVM = null;

            if (cmbRoller.SelectedIndex != -1)
            {
                rolVM = cmbRoller.SelectedItem as RolVM;
            }

            if (cmbSayfalar.SelectedIndex != -1)
            {
                sayfaVM = cmbSayfalar.SelectedItem as SayfaVM;
            }

            if (rolVM != null && sayfaVM != null)
            {
                List<RolYetkiVM> lst = _unitOfWork.RolYetkiRepository.RolYetkiVMListesiGetir(rolVM, sayfaVM);

                RolYetkiDoldur(lst);
            }

        }

        private void cmbSayfalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            RolVM rolVM = null;
            SayfaVM sayfaVM = null;

            if (cmbRoller.SelectedIndex != -1)
            {
                rolVM = cmbRoller.SelectedItem as RolVM;
            }

            if (cmbSayfalar.SelectedIndex != -1)
            {
                sayfaVM = cmbSayfalar.SelectedItem as SayfaVM;
            }

            if (rolVM != null && sayfaVM != null)
            {
                List<RolYetkiVM> lst = _unitOfWork.RolYetkiRepository.RolYetkiVMListesiGetir(rolVM, sayfaVM);

                RolYetkiDoldur(lst);
            }
         
        }
    }
}
