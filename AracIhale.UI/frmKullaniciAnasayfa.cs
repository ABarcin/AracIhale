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
    public partial class frmKullaniciAnasayfa : Form
    {
        public frmKullaniciAnasayfa()
        {
            InitializeComponent();
        }

        private void btnIhaleListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmIhaleListeleme ihaleListeleme = new frmIhaleListeleme())
            {
                ihaleListeleme.ShowDialog();
            }
            this.Show();
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAracTanimlamaListeleme aracTanimlamaListeleme = new frmAracTanimlamaListeleme())
            {
                aracTanimlamaListeleme.ShowDialog();
            }
            this.Show();
        }
    }
}
