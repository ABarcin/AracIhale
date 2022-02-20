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
        public frmTramerBilgileri()
        {
            InitializeComponent();
        }

        UnitOfWork _unitOfWork = new UnitOfWork(new AracIhaleEntities());

        private void frmTramerBilgileri_Load(object sender, EventArgs e)
        {
            PrepareForm();
        }

        private void PrepareForm()
        {
            var aracParcaListesi = _unitOfWork.AracParcaRepository.AracParcaListesiGetir();
            var tramerDurumListesi = _unitOfWork.TramerDetayRepository.TramerDurumListesiGetir();

            foreach (var item in tramerDurumListesi)
            {
                flpTramerDurum.Controls.Add(new Label 
                {
                    Text = item.TramerDurum
                });
            }

            foreach (var aracParca in aracParcaListesi)
            {
                FlowLayoutPanel flpAracParca = new FlowLayoutPanel
                {
                    Name = "flp" + aracParca.ParcaAd,
                    Width = 600,
                    Height = 25
                };
                Label lblAracParca = new Label
                {
                    Text = aracParca.ParcaAd
                };

                flpAracParca.Controls.Add(lblAracParca);

                for (int i = 1; i <= tramerDurumListesi.Count(); i++)
                {
                    RadioButton rdb = new RadioButton
                    {
                        Name = "rdb" + aracParca.ParcaAd + tramerDurumListesi[i - 1].TramerDurum

                    };
                    if (i == 1)
                        rdb.Checked = true;

                    flpAracParca.Controls.Add(rdb);
                    //(flpAracParca.Controls[flpAracParca.Controls.Count - 1] as RadioButton).Location = new Point(-i * flpAracParca.Width / 4, -flpAracParca.Height);
                }

                flpRuntime.Controls.Add(flpAracParca);

            }
        }

        int _aracID = 3;
        int _aracTramerID;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    List<AracParcaVM> aracParcaListesi = _unitOfWork.AracParcaRepository.AracParcaListesiGetir();
                    List<TramerDetayVM> tramerDurumListesi = _unitOfWork.TramerDetayRepository.TramerDurumListesiGetir();
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

                    _unitOfWork.AracTramerRepository.Add(new AracTramerMapping().AracTramerVMToAracTramer(aracTramerVM));
                    _unitOfWork.Complate();

                    _aracTramerID = _unitOfWork.AracTramerRepository.GetAll().OrderByDescending(x => x.AracTramerID).First().AracTramerID;

                    List<AracTramerDetayVM> aracTramerDetayVMList = TramerBilgileriGetir(aracParcaListesi, tramerDurumListesi, _aracTramerID);

                    if (aracTramerDetayVMList.Count() != aracParcaListesi.Count())
                    {
                        throw new Exception();
                    }

                    foreach (var aracTramerDetayVM in aracTramerDetayVMList)
                    {
                        _unitOfWork.AracTramerDetayRepository.Add(new AracTramerDetayMapping().AracTramerVMToAracTramer(aracTramerDetayVM));
                        _unitOfWork.Complate();
                    }

                    scope.Complete();
                    MessageBox.Show("Test Datası eklenmeye çalışıldı, database'i kontrol ediniz");
                }
                catch (Exception)
                {

                }
            }
        }

        List<AracTramerDetayVM> TramerBilgileriGetir(List<AracParcaVM> aracParcaListesi, List<TramerDetayVM> tramerDurumListesi, int aracTramerID)
        {
            List<AracTramerDetayVM> aracTramerDetayVMList = new List<AracTramerDetayVM>();

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

                                        aracTramerDetayVMList.Add(aracTramerDetayVM);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return aracTramerDetayVMList;
        }
    }
}
