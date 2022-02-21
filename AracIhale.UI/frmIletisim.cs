using AracIhale.CORE;
using AracIhale.CORE.Login;
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

        }

        private void IletisimBilgileriniDoldur()
        {
            lsvIletisim.Items.Clear();
            using (unitOfWork = new UnitOfWork(new AracIhaleEntities()))
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
        }

        private void CmbDoldurIletisimTurDoldur()
        {
            using (unitOfWork=new UnitOfWork(new AracIhaleEntities()))
            {
                cmbIletisimTur.Items.AddRange(unitOfWork.IletisimTurRepository.IletisimTurleriniGetir().ToArray());
            }
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            validation = new Validation();
            if ((cmbIletisimTur.SelectedItem as IletisimTurVM).Ad=="Email")
            {
                if (validation.IsValidateEmail(txtIletisimBilgi, errorProvider)&&cmbIletisimTur.SelectedItem!=null) 
                {
                    using (unitOfWork=new UnitOfWork(new AracIhaleEntities()))
                    {
                        CalisanIletisimVM vm = new CalisanIletisimVM()
                        {
                            CalisanID = calisan.CalisanID,
                            IletisimTuruID = (cmbIletisimTur.SelectedItem as IletisimTurVM).IletisimTuruID,
                            IletisimBilgi = txtIletisimBilgi.Text,
                            IsActive=true
                        };
                        unitOfWork.CalisanIletisimRepository.IletisimBilgisiEkle(vm);
                        unitOfWork.Complate();
                        IletisimBilgileriniDoldur();
                        
                    }
                }
            }
        }
    }
}
