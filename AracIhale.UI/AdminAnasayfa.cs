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
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (KullaniciListeleme kullaniciListeleme=new KullaniciListeleme())
            {
                kullaniciListeleme.ShowDialog();
            }
            this.Show();
        }

        private void btnAraclslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AracTanimlamaListeleme aracTanimlamaListeleme=new AracTanimlamaListeleme())
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
            using (UyeListeleme uyeListeleme=new UyeListeleme())
            {
                uyeListeleme.ShowDialog();
            }
            this.Show();
        }
    }
}
