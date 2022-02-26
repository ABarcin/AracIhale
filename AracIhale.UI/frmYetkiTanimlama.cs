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
                    Name = yetki.YetkiAciklama,
                };

                flpYetkiler.Controls.Add(cbYetki);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
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
                    foreach (var control in flpYetkiler.Controls)
                    {
                        if (control.GetType() == typeof(CheckBox))
                        {
                            CheckBox checkBox = control as CheckBox;

                            foreach (var yetkiVM in _yetkiListesi)
                            {
                                if (checkBox.Checked && checkBox.Name == yetkiVM.YetkiAciklama)
                                {
                                    _unitOfWork.RolYetkiRepository.RolYetkiGuncelle(rolVM, sayfaVM);
                                    _unitOfWork.Complate();
                                }
                            }
                        }
                    }
                }

                scope.Complete();
            }

        }
    }
}
