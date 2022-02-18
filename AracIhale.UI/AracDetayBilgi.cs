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
    public partial class AracDetayBilgi : Form
    {
        public AracDetayBilgi()
        {
            InitializeComponent();
        }
        private void btnTramerBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (TramerBilgileri tramerBilgileri=new TramerBilgileri())
            {
                tramerBilgileri.ShowDialog();
            }
            this.Show();
        }

        private void btnIlanBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (IlanBilgileri ilanBilgileri=new IlanBilgileri())
            {
                ilanBilgileri.ShowDialog();
            }
            this.Show();
        }

        private void btnAracTarihce_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AracTarihce aracTarihce=new AracTarihce())
            {
                aracTarihce.ShowDialog();
            }
            this.Show();
        }

        private void btnAliciBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AliciBilgileri aliciBilgileri=new AliciBilgileri())
            {
                aliciBilgileri.ShowDialog();
            }
            this.Show();
        }
    }
}
