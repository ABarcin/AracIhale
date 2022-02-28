using System;
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
