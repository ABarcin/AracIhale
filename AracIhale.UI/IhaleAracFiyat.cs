using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracIhale.DAL.UnitOfWork;
using AracIhale.MODEL.Mapping;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;

namespace AracIhale.UI
{
    public partial class IhaleAracFiyat : Form
    {
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        public IhaleAracFiyat()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            IhaleAracVM ihaleAracVM = new IhaleAracVM();
            ihaleAracVM.AracID = int.Parse(txtIhaleAd.Text);
            ihaleAracVM.IhaleBaslangicFiyat = decimal.Parse(txtIhaleBaslangicFiyat.Text);
            ihaleAracVM.MinAlimFiyati = decimal.Parse(txtIhaleBitisFiyat.Text);
            ihaleAracVM.IhaleID = unitOfWork.IhaleRepository.GetAll().LastOrDefault().IhaleID;

            unitOfWork.IhaleAracRepository.Add(new IhaleAracMapping().IhaleAracVMToIhaleArac(ihaleAracVM));
            unitOfWork.Complate();
            Clear();
        }

        private void Clear()
        {
            txtIhaleBaslangicFiyat.Text = string.Empty;
            txtIhaleBitisFiyat.Text = string.Empty;
            txtIhaleAd.Text = string.Empty;
        }
    }
}
