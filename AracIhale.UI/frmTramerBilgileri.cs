using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmTramerBilgileri : Form
    {
        int _aracID;
        string _createdBy;
        string _modifiedBy;

        public frmTramerBilgileri()
        {
            InitializeComponent();
        }
        public frmTramerBilgileri(int aracID) : this()
        {
            _aracID = aracID;
        }

        UnitOfWork _unitOfWork = new UnitOfWork();
        List<AracParcaVM> _aracParcaListesi;
        List<TramerDetayVM> _tramerDurumListesi;

        private void frmTramerBilgileri_Load(object sender, EventArgs e)
        {
            _aracParcaListesi = _unitOfWork.AracParcaRepository.AracParcaListesiGetir();
            _tramerDurumListesi = _unitOfWork.TramerDetayRepository.TramerDurumListesiGetir();
            PrepareForm();
            PrepareFormByLoggedUser();
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
                _modifiedBy = _createdBy = Login.GirisYapmisCalisan.Ad;
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

        private void PrepareForm()
        {
            AracTramerVM aracTramerVM = _unitOfWork.AracTramerRepository.AracTramerVMGetir(_aracID);
            List<AracTramerDetayVM> aracTramerDetayVMList = new List<AracTramerDetayVM>();

            if (aracTramerVM == null)
            {
                btnGuncelle.Enabled = false;
                MessageBox.Show("Araca dair tramer bilgileri henüz bulunmamaktadır. Lütfen verileri düzenleyin ve 'Kaydet' butonuna tıklayınız.");
            }
            else
            {
                aracTramerDetayVMList = _unitOfWork.AracTramerDetayRepository.AracTramerVMListesiniGetir(aracTramerVM.AracTramerID);
                MessageBox.Show("Bilgiler daha önce kaydedilmiştir Güncel Tramer bilgileri görüntülenmektedir." +
                                " Güncellemek için verileri düzenleyin ve 'Güncelle' butonuna tıklayınız.'Kaydet'" +
                                " butonuna tıklayarak araç için yeni bir tramer kaydı oluşturabilirsiniz");
            }

            foreach (var item in _tramerDurumListesi)
            {
                flpTramerDurum.Controls.Add(new Label
                {
                    Text = item.TramerDurum
                });
            }

            foreach (var aracParca in _aracParcaListesi)
            {
                FlowLayoutPanel flpAracParca = new FlowLayoutPanel
                {
                    Name = "flp" + aracParca.ParcaAd,
                    Width = 600,
                    Height = 25
                };
                Label lblAracParca = new Label
                {
                    Text = aracParca.ParcaAd,
                    Anchor = AnchorStyles.Bottom
                };

                flpAracParca.Controls.Add(lblAracParca);

                for (int i = 0; i < _tramerDurumListesi.Count(); i++)
                {
                    RadioButton rdb = new RadioButton
                    {
                        Name = "rdb" + aracParca.ParcaAd + _tramerDurumListesi[i].TramerDurum
                    };

                    if (aracTramerVM == null)
                    {
                        if (i == 0)
                        {
                            rdb.Checked = true;
                        }
                    }
                    else
                    {
                        txtMoney.Text = aracTramerVM.Fiyat.ToString();

                        foreach (var item in aracTramerDetayVMList)
                        {
                            string aracParcaAdi = _aracParcaListesi.Where(x => x.AracParcaID == item.AracParcaID).Select(x => x.ParcaAd).First();
                            string tramerDurum = _tramerDurumListesi.Where(x => x.TramerDetayID == item.TramerDetayID).Select(x => x.TramerDurum).First();
                            string isaretlenecekButton = "rdb" + aracParcaAdi + tramerDurum;

                            if (rdb.Name == isaretlenecekButton)
                            {
                                rdb.Checked = true;
                            }
                        }
                    }

                    flpAracParca.Controls.Add(rdb);
                }

                flpRuntime.Controls.Add(flpAracParca);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    AracTramerVM aracTramerVM = new AracTramerVM();

                    if (new Validation().IsValidateMoney(txtMoney, epMoney))
                    {
                        aracTramerVM.AracID = _aracID;
                        aracTramerVM.Fiyat = decimal.Parse(txtMoney.Text);
                        aracTramerVM.CreatedBy = aracTramerVM.ModifiedBy = _createdBy;
                    }
                    else
                    {
                        throw new Exception();
                    }

                    int aracTramerID = _unitOfWork.AracTramerRepository.AracTramerEkle(aracTramerVM);

                    AracTramerDetaylariEkle(_aracParcaListesi, _tramerDurumListesi, aracTramerID);

                    scope.Complete();
                    btnGuncelle.Enabled = true;
                    MessageBox.Show("Tramer Bilgileri başarıyla eklendi.");
                }
                catch (Exception)
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
                    AracTramerVM aracTramerVM = _unitOfWork.AracTramerRepository.AracTramerVMGetir(_aracID);

                    if (new Validation().IsValidateMoney(txtMoney, epMoney))
                    {
                        aracTramerVM.Fiyat = decimal.Parse(txtMoney.Text);
                        aracTramerVM.ModifiedBy = _modifiedBy;
                    }
                    else
                    {
                        throw new Exception();
                    }

                    _unitOfWork.AracTramerRepository.AracTramerGuncelle(aracTramerVM);
                    _unitOfWork.Complete();

                    int aracTramerID = aracTramerVM.AracTramerID;

                    AracTramerDetaylariGuncelle(_aracParcaListesi, _tramerDurumListesi, aracTramerID);

                    scope.Complete();
                    MessageBox.Show("Tramer Bilgileri başarıyla güncellendi!");
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        void AracTramerDetaylariEkle(List<AracParcaVM> aracParcaListesi, List<TramerDetayVM> tramerDurumListesi, int aracTramerID)
        {
            foreach (var flpAracParca in flpRuntime.Controls)
            {
                foreach (var control in (flpAracParca as FlowLayoutPanel).Controls)
                {
                    if (control.GetType() == typeof(RadioButton))
                    {
                        RadioButton rdb = control as RadioButton;

                        foreach (var aracParca in aracParcaListesi)
                        {
                            foreach (var tramerDurum in tramerDurumListesi)
                            {
                                if (("rdb" + aracParca.ParcaAd + tramerDurum.TramerDurum) == rdb.Name)
                                {
                                    if (rdb.Checked)
                                    {
                                        AracTramerDetayVM aracTramerDetayVM = new AracTramerDetayVM
                                        {
                                            AracTramerID = aracTramerID,
                                            AracParcaID = aracParca.AracParcaID,
                                            TramerDetayID = tramerDurum.TramerDetayID,
                                            CreatedBy = _createdBy,
                                            ModifiedBy = _modifiedBy
                                        };

                                        _unitOfWork.AracTramerDetayRepository.AracTramerDetayEkle(aracTramerDetayVM);
                                        _unitOfWork.Complete();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        void AracTramerDetaylariGuncelle(List<AracParcaVM> aracParcaListesi, List<TramerDetayVM> tramerDurumListesi, int aracTramerID)
        {
            foreach (var flpAracParca in flpRuntime.Controls)
            {
                foreach (var control in (flpAracParca as FlowLayoutPanel).Controls)
                {
                    if (control.GetType() == typeof(RadioButton))
                    {
                        RadioButton rdb = control as RadioButton;

                        foreach (var aracParca in aracParcaListesi)
                        {
                            foreach (var tramerDurum in tramerDurumListesi)
                            {
                                if (("rdb" + aracParca.ParcaAd + tramerDurum.TramerDurum) == rdb.Name)
                                {
                                    if (rdb.Checked)
                                    {
                                        AracTramerDetayVM aracTramerDetayVM = _unitOfWork.AracTramerDetayRepository
                                            .AracTramerDetayVMGetir(aracTramerID, aracParca.AracParcaID);

                                        aracTramerDetayVM.TramerDetayID = tramerDurum.TramerDetayID;
                                        aracTramerDetayVM.ModifiedBy = _modifiedBy;
                                        aracTramerDetayVM.ModifiedDate = DateTime.Now;

                                        _unitOfWork.AracTramerDetayRepository.AracTramerDetayGuncelle(aracTramerDetayVM);
                                        _unitOfWork.Complete();

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
