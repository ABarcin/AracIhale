using AracIhale.DAL.UnitOfWork;
using System;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmAracTarihce : Form
    {
        int _aracID;
        public frmAracTarihce()
        {
            InitializeComponent();
        }
        public frmAracTarihce(int aracID) : this()
        {
            _aracID = aracID;
        }
        UnitOfWork unitOfWork = new UnitOfWork();
        private void frmAracTarihce_Load(object sender, EventArgs e)
        {
            AracStatuTarihcesiListele();
        }

        private void AracStatuTarihcesiListele()
        {
            int counter = 1;
            foreach (var statu in unitOfWork.AracStatuRepository.AracinStatuTarihcesiniGetir(_aracID))
            {
                ListViewItem li = new ListViewItem();
                li.Text = counter++.ToString();
                li.SubItems.Add(statu.StatuAd);
                li.SubItems.Add(statu.Tarih.ToString());
                lstAracTarihce.Items.Add(li);
            }
        }
    }
}
