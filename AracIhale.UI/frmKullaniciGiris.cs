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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login yapildiginda aksiyon alinmasi gereken yer.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmIhaleListeleme ihaleListeleme = new frmIhaleListeleme())
            {
                ihaleListeleme.ShowDialog();
            }
            this.Show();
        }
    }
}
