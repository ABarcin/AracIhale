using AracIhale.CORE;
using AracIhale.CORE.Login;
using AracIhale.CORE.VM;
using AracIhale.DAL.UnitOfWork;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmIletisim : Form
    {
        public frmIletisim(CalisanVM calisan)
        {
            InitializeComponent();
            this.calisan = calisan;
        }
        CalisanVM calisan;
        UnitOfWork unitOfWork;
        Validation validation;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIletisimTur.SelectedItem.ToString()=="Adress")
            {
                txtIletisimBilgi.Multiline = true;
                txtIletisimBilgi.Size = new Size(345, 95);
                btnKaydet.Location = new Point(txtIletisimBilgi.Location.X+265, txtIletisimBilgi.Location.Y+100);
            }
            else
            {
                txtIletisimBilgi.Multiline = false;
                txtIletisimBilgi.Size = new Size(195,20);
                btnKaydet.Location = new Point(txtIletisimBilgi.Location.X+115, txtIletisimBilgi.Location.Y+26);
            }
        }

        private void frmIletisim_Load(object sender, EventArgs e)
        {
            CmbDoldurIletisimTurDoldur();
            IletisimBilgileriniDoldur();
            btnGuncelle.Enabled = false;

        }

        private void IletisimBilgileriniDoldur()
        {
            lsvIletisim.Items.Clear();
            using (unitOfWork = new UnitOfWork())
            {
                ListViewItem listView;
                foreach (var item in unitOfWork.CalisanIletisimRepository.IletisimBilgileriniGetir(calisan))
                {
                    string[] row = { item.IletisimTuruID.ToString(), item.IletisimBilgi };
                    listView = new ListViewItem(row);
                    listView.Tag = item;
                    lsvIletisim.Items.Add(listView);
                }

            }
            if (cmbIletisimTur.Items.Count>0)
            {
                cmbIletisimTur.SelectedIndex = 0;
            }
            
        }

        private void CmbDoldurIletisimTurDoldur()
        {
            using (unitOfWork=new UnitOfWork())
            {
                cmbIletisimTur.Items.AddRange(unitOfWork.IletisimTurRepository.IletisimTurleriniGetir().ToArray());
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            validation = new Validation();
            if (cmbIletisimTur.SelectedIndex != -1)
            {
                string iletisimTur = (cmbIletisimTur.SelectedItem as IletisimTurVM).Ad.ToLower();
                if (iletisimTur == "email" || iletisimTur == "mail")
                {
                    if (validation.IsValidateEmail(txtIletisimBilgi, errorProvider))
                    {
                        IletisimEkle();
                    }
                }
                else if (iletisimTur == "telefon" || iletisimTur == "phone" || iletisimTur == "cep" || iletisimTur == "mobile")
                {
                    if (validation.IsValidatePhoneNumber(txtIletisimBilgi, errorProvider))
                    {
                        IletisimEkle();
                    }
                }
                else if (iletisimTur == "adres" || iletisimTur == "adress")
                {
                    if (!string.IsNullOrWhiteSpace(txtIletisimBilgi.Text))
                    {
                        IletisimEkle();
                    }
                }
            }
            else 
            {
                errorProvider.SetError(btnKaydet, "İletişim Tür Seçiniz");
            }
            
        }

        private void IletisimEkle()
        {
            using (unitOfWork = new UnitOfWork())
            {
                CalisanIletisimVM vm = new CalisanIletisimVM()
                {
                    CalisanID = calisan.CalisanID,
                    IletisimTuruID = (cmbIletisimTur.SelectedItem as IletisimTurVM).IletisimTuruID,
                    IletisimBilgi = txtIletisimBilgi.Text,
                    IsActive = true,
                    CreatedBy=Login.GirisYapmisCalisan.KullaniciAd,
                    ModifiedBy=Login.GirisYapmisCalisan.KullaniciAd
                    
                };
                unitOfWork.CalisanIletisimRepository.IletisimBilgisiEkle(vm);
                unitOfWork.Complete();
                IletisimBilgileriniDoldur();
            }
        }

        private void lsvIletisim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvIletisim.SelectedItems.Count>0)
            {
                btnKaydet.Enabled = false;
                btnGuncelle.Enabled = true;
                foreach (IletisimTurVM item in cmbIletisimTur.Items)
                {
                    if (item.IletisimTuruID==(lsvIletisim.SelectedItems[0].Tag as CalisanIletisimVM).IletisimTuruID)
                    {
                        cmbIletisimTur.SelectedItem = item;
                    }
                }
                txtIletisimBilgi.Text = (lsvIletisim.SelectedItems[0].Tag as CalisanIletisimVM).IletisimBilgi;
            }
            else
            {
                btnKaydet.Enabled = true;
                btnGuncelle.Enabled = false;
                cmbIletisimTur.SelectedIndex = 0;
                txtIletisimBilgi.Text = string.Empty;
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            validation = new Validation();
            string iletisimTur = (cmbIletisimTur.SelectedItem as IletisimTurVM).Ad.ToLower();
            if (iletisimTur == "email" || iletisimTur == "mail")
            {
                if (validation.IsValidateEmail(txtIletisimBilgi, errorProvider))
                {
                    IletisimGuncelle();
                }
            }
            else if (iletisimTur == "telefon" || iletisimTur == "phone" || iletisimTur == "cep" || iletisimTur == "mobile")
            {
                if (validation.IsValidatePhoneNumber(txtIletisimBilgi, errorProvider))
                {
                    IletisimGuncelle();
                }
            }
            else if (iletisimTur == "adres" || iletisimTur == "adress")
            {
                if (!string.IsNullOrWhiteSpace(txtIletisimBilgi.Text))
                {
                    IletisimGuncelle();
                }
            }
        }

        private void IletisimGuncelle()
        {
            using (unitOfWork = new UnitOfWork())
            {
                CalisanIletisimVM vm = new CalisanIletisimVM()
                {
                    CalisanID = calisan.CalisanID,
                    IletisimTuruID = (cmbIletisimTur.SelectedItem as IletisimTurVM).IletisimTuruID,
                    IletisimBilgi = txtIletisimBilgi.Text,
                    IsActive = true,
                    CalisanIletisimID = (lsvIletisim.SelectedItems[0].Tag as CalisanIletisimVM).CalisanIletisimID,
                    ModifiedBy = Login.GirisYapmisCalisan.KullaniciAd

                    
                };
                unitOfWork.CalisanIletisimRepository.IletisimBilgisiGuncelle(vm);
                unitOfWork.Complete();
                IletisimBilgileriniDoldur();
                errorProvider.Clear();
            }
        }
    }
}
