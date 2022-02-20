using AracIhale.CORE;
using AracIhale.DAL.Repositories.Abstract;
using AracIhale.DAL.Repositories.Concrete;
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
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class CalisanKayit : Form
    {
        public CalisanKayit()
        {
            InitializeComponent();
        }
        CalisanRepository repository;
        RolRepository rolRepository;
        private void CalisanKayit_Load(object sender, EventArgs e)
        {
            ListCalisanlarDoldur();
            CmbRolDoldur();
            cmbRol.SelectedIndex = 1;
        }

        private void CmbRolDoldur()
        {
            rolRepository = new RolRepository(new AracIhaleEntities());
            foreach (RolVM item in rolRepository.TumRoller())
            {
                cmbRol.Items.Add(item);
            }
        }

        private void ListCalisanlarDoldur()
        {
            repository = new CalisanRepository(new AracIhaleEntities());
            foreach (CalisanVM item in repository.TumCalisanlar())
            {
                string[] row = { item.Ad, item.Soyad, item.RolAd };
                var satir = new ListViewItem(row);
                satir.Tag = item;
                listCalisanlar.Items.Add(satir);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (listCalisanlar.SelectedItems.Count > 0)
            {
                unitOfWork = new UnitOfWork(new AracIhaleEntities());
                validation = new Validation();
                CalisanVM calisan = CalisanKontrol();
                if (calisan != null)
                {
                    unitOfWork.CalisanRepository.Guncelle(calisan);
                    unitOfWork.Complate();
                    FormuTemizle();
                }
                else
                {
                    errorProvider.SetError(btnGuncelle, "Hata");
                }

            }
            else
            {
                errorProvider.SetError(btnGuncelle, "Lütfen Güncellemek İstediğiniz Çalışanı Seçiniz");
            }
        }

        private CalisanVM CalisanKontrol()
        {
            CalisanVM calisan = null;
            if (validation.IsValidateName(txtAd, 2, 150, errorProvider) && validation.IsValidateName(txtSoyad, 2, 200, errorProvider) && validation.IsValidateUserName(txtKullaniciAdi, errorProvider, 3, 25)  && validation.IsValidatePassWord(txtSifre, errorProvider, 3, 30) && SifreKontrol())
            {
                calisan = new CalisanVM();
                calisan.CalisanID = (listCalisanlar.SelectedItems[0].Tag as CalisanVM).CalisanID;
                calisan.Ad = txtAd.Text;
                calisan.Soyad = txtSoyad.Text;
                calisan.KullaniciAd = txtKullaniciAdi.Text;
                calisan.RolID = (cmbRol.SelectedItem as RolVM).RolID;
                calisan.Sifre = txtSifre.Text;
                if (rdbAktif.Checked == true)
                {
                    calisan.AktiflikDurumu = true;
                }
                else
                {
                    calisan.AktiflikDurumu = false;
                }
            }
            return calisan;
        }
       

        Validation validation;
        UnitOfWork unitOfWork;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            unitOfWork = new UnitOfWork(new AracIhaleEntities());
            validation = new Validation();
            CalisanVM calisan = CalisanKontrol();
            if (calisan != null)
            {
                unitOfWork.CalisanRepository.Ekle(calisan);
                unitOfWork.Complate();
                FormuTemizle();
            }
            else
            {
                errorProvider.SetError(btnKaydet, "Hata");
            }
        }
        private void FormuTemizle()
        {
            txtAd.Text = txtKullaniciAdi.Text = txtSifre.Text = txtSifreTekrar.Text = txtSoyad.Text = string.Empty;
            rdbAktif.Checked = true;
            listCalisanlar.Items.Clear();
            ListCalisanlarDoldur();
            cmbRol.SelectedIndex = 1;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private bool SifreKontrol()
        {
            bool dogruMu = false;
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                dogruMu = true;
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(txtSifreTekrar, "Şifreler Uyuşmuyor");
            }
            return dogruMu;
        }
        private void listCalisanlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCalisanlar.SelectedItems.Count > 0)
            {
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
                btnKaydet.Enabled = false;
                CalisanVM calisan = listCalisanlar.SelectedItems[0].Tag as CalisanVM;
                txtAd.Text = calisan.Ad;
                txtSoyad.Text = calisan.Soyad;
                txtKullaniciAdi.Text = calisan.KullaniciAd;
                txtSifre.Text = calisan.Sifre;
                if (calisan.AktiflikDurumu == true)
                {
                    rdbAktif.Checked = true;
                }
                else
                {
                    rdbPasif.Checked = true;
                }
                foreach (RolVM item in cmbRol.Items)
                {
                    if (item.Ad == calisan.RolAd)
                    {
                        cmbRol.SelectedItem = item;
                    }
                }
            }
            else
            {
                btnSil.Enabled = false;
                btnGuncelle.Enabled = false;
                btnKaydet.Enabled = true;
                FormuTemizle();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            unitOfWork = new UnitOfWork(new AracIhaleEntities());
            unitOfWork.CalisanRepository.Sil((listCalisanlar.SelectedItems[0].Tag as CalisanVM).CalisanID);
            int etkilenen=unitOfWork.Complate();
            if (etkilenen>0)
            {
                FormuTemizle();
            }
            else
            {
                errorProvider.SetError(btnSil, "Hata");
            }
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
