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
    public partial class UyeOnay : Form
    {
        public UyeOnay()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (chkOnay.Checked==true&&cmbPaket.SelectedIndex>=0)
            {
                errorProvider.Clear();
            }
            else
            {
                errorProvider.SetError(btnKaydet, "Paket Seçmediniz Yada Onay Vermediniz");
            }
        }
    }
}
