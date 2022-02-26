using AracIhale.CORE;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Mapping;
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
    public partial class frmTramerBilgileri : Form
    {
        int _aracID = 1035; // injection metodu ile fatihten alınacak

        public frmTramerBilgileri()
        {
            InitializeComponent();
        }
        public frmTramerBilgileri(int aracID):this()
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
                btnKaydet.Enabled = false;
                MessageBox.Show("Bilgiler daha önce kaydedilmiştir. Güncellemek için verileri düzenleyin ve 'Güncelle' butonuna tıklayınız.");
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
                    }
                    else
                    {
                        throw new Exception();
                    }

                    int aracTramerID = _unitOfWork.AracTramerRepository.AracTramerEkle(aracTramerVM);

                    AracTramerDetaylariEkle(_aracParcaListesi, _tramerDurumListesi, aracTramerID);

                    scope.Complete();
                    btnKaydet.Enabled = false;
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
                                            TramerDetayID = tramerDurum.TramerDetayID
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
