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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnBireysel_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmKullaniciKayit bireyselUyeKayit=new frmKullaniciKayit())
            {
                bireyselUyeKayit.ShowDialog();
            }
            this.Show();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmKullaniciGiris kullaniciGiris = new frmKullaniciGiris())
            {
                kullaniciGiris.ShowDialog();
            }
            this.Show();
        }
    }
}
