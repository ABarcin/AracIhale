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
    public partial class frmUygulamaAnaAsayfa : Form
    {
        public frmUygulamaAnaAsayfa()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Hide();
            using (frmYonetimPaneli frm = new frmYonetimPaneli())
            {
                frm.ShowDialog();
            }
            Close();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            Hide();
            using (frmAnasayfa frm = new frmAnasayfa())
            {
                frm.ShowDialog();
            }
            Close();

        }
    }
}
