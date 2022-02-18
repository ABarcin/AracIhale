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
            using (BireyselUyeKayit bireyselUyeKayit=new BireyselUyeKayit())
            {
                bireyselUyeKayit.ShowDialog();
            }
            this.Show();
        }

        private void btnKurumsal_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (KurumsalUyeKayit kurumsalUyeKayit=new KurumsalUyeKayit())
            {
                kurumsalUyeKayit.ShowDialog();
            }
            this.Show();
        }
    }
}
