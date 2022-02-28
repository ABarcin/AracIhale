using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmIlanBilgileri : Form
    {
        int _aracID; 
        IlanVM _ilanVM;
        string _createdBy;
        string _modifiedBy;

        public frmIlanBilgileri()
        {
            InitializeComponent();
        }
        public frmIlanBilgileri(int aracID) : this()
        {
            _aracID = aracID;
        }

        UnitOfWork _unitOfWork = new UnitOfWork();

        private void frmIlanBilgileri_Load(object sender, EventArgs e)
        {
            PrepareForm();
            PrepareFormByLoggedUser();
        }

        private void PrepareForm()
        {
            _ilanVM = _unitOfWork.IlanRepository.IlanVMGetir(_aracID);

            if (_ilanVM == null)
            {
                btnGuncelle.Enabled = false;

                MessageBox.Show("Araç için henüz bir ilan oluşturulmamıştır. İlan eklemek için bilgileri düzenleyip 'Kaydet' butonuna basınız.");  
            }
            else
            {
                txtIlanBaslik.Text = _ilanVM.Baslik;
                txtIlanAciklama.Text = _ilanVM.Aciklama;

                btnKaydet.Enabled = false;

                MessageBox.Show("Araç için ilan bilgisi bulunmaktadır. İlan bilgilerini güncellemek için bilgileri düzenleyip 'Güncelle' butonuna basınız.");
            }
        }

        private void PrepareFormByLoggedUser()
        {
            if (Login.GirisYapmisCalisan != null && Login.GirisYapmisKullanici != null)
            {
                LockForm();
            }

            else if (Login.GirisYapmisCalisan != null)
            {
                RolYetkiKontrol();
                _modifiedBy = _createdBy = Login.GirisYapmisCalisan.Ad;
            }

            else if (Login.GirisYapmisKullanici != null)
            {
                RolYetkiKontrol();
                _modifiedBy = _createdBy = Login.GirisYapmisKullanici.Ad;
            }

            else
            {
                LockForm();
            }
        }

        private void RolYetkiKontrol()
        {
            var rolYetki = Login.SayfaYetkiYonetimiListesi.FirstOrDefault(x => x.Sayfa.SayfaAdi == this.Name);

            if (rolYetki.YetkiListesi.Count > 0)
            {
                if (rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Read"))
                {
                    bool create = rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Create");
                    bool update = rolYetki.YetkiListesi.Any(x => x.YetkiAciklama == "Update");

                    if (!create)
                    {
                        btnKaydet.Visible = false;
                    }
                    if (!update)
                    {
                        btnGuncelle.Visible = false;
                    }
                    if (!create && !update)
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using(TransactionScope scope = new TransactionScope())
            {
                try
                {
                    bool baslik = new Validation().IsTextBoxNullOrWhiteSpace(txtIlanBaslik, epBaslik, "İlan Başlığı boş bırakılamaz. Lütfen Doldurunuz.");
                    bool aciklama = new Validation().IsTextBoxNullOrWhiteSpace(txtIlanAciklama, epAciklama, "İlan açıklaması boş bırakılamaz. Lütfen doldurunuz.");

                    if (baslik && aciklama)
                    {
                        _ilanVM = new IlanVM
                        {
                            AracID = _aracID,
                            Baslik = txtIlanBaslik.Text,
                            Aciklama = txtIlanAciklama.Text,
                            CreatedBy = _createdBy,
                            ModifiedBy = _modifiedBy
                            
                        };

                        _unitOfWork.IlanRepository.IlanEkle(_ilanVM);
                        _unitOfWork.Complete();
                    }
                    else
                    {
                        throw new Exception();
                    }

                    scope.Complete();

                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    MessageBox.Show("İlan başarıyla kaydedildi.");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    bool baslik = new Validation().IsTextBoxNullOrWhiteSpace(txtIlanBaslik, epBaslik, "İlan Başlığı boş bırakılamaz. Lütfen Doldurunuz.");
                    bool aciklama = new Validation().IsTextBoxNullOrWhiteSpace(txtIlanAciklama, epAciklama, "İlan açıklaması boş bırakılamaz. Lütfen doldurunuz.");

                    if (baslik && aciklama)
                    {
                        _ilanVM.Baslik = txtIlanBaslik.Text;
                        _ilanVM.Aciklama = txtIlanAciklama.Text;
                        _ilanVM.ModifiedDate = DateTime.Now;

                        _unitOfWork.IlanRepository.IlanGuncelle(_ilanVM);
                        _unitOfWork.Complete();
                    }
                    else
                    {
                        throw new Exception();
                    }

                    scope.Complete();
                    MessageBox.Show("İlan başarıyla güncellendi.");
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
