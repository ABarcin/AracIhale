using System;
using System.Windows.Forms;

namespace AracIhale.UI
{
    public partial class frmAdminAnasayfa : Form
    {
        public frmAdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmCalisanListeleme calisanListeleme=new frmCalisanListeleme())
            {
                calisanListeleme.ShowDialog();
            }
            this.Show();
        }

        private void btnAraclslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmAracTanimlamaListeleme aracTanimlamaListeleme=new frmAracTanimlamaListeleme())
            {
                aracTanimlamaListeleme.ShowDialog();
            }
            this.Show();
        }

        private void btnIhaleIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmIhaleListeleme ihaleListeleme = new frmIhaleListeleme())
            {
                ihaleListeleme.ShowDialog();
            }
            this.Show();
        }

        private void btnUyeListeleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmUyeListeleme uyeListeleme=new frmUyeListeleme())
            {
                uyeListeleme.ShowDialog();
            }
            this.Show();
        }

        private void frmAdminAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnYetkiTanimlama_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmYetkiTanimlama yetkiTanimlama = new frmYetkiTanimlama())
            {
                yetkiTanimlama.ShowDialog();
            }
            this.Show();
        }
    }
}
