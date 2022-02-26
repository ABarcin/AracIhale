using AracIhale.CORE;
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
    public partial class frmIlanBilgileri : Form
    {
        int _aracID = 4; //TODO: injection methodu ile fatihten alınacak
        IlanVM _ilanVM;

        public frmIlanBilgileri()
        {
            InitializeComponent();
        }

        UnitOfWork _unitOfWork = new UnitOfWork();

        private void frmIlanBilgileri_Load(object sender, EventArgs e)
        {
            PrepareForm();
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
                            Aciklama = txtIlanAciklama.Text
                        };

                        _unitOfWork.IlanRepository.IlanEkle(_ilanVM);
                        _unitOfWork.Complate();
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

                        _unitOfWork.IlanRepository.IlanGuncelle(_ilanVM);
                        _unitOfWork.Complate();
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
