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
    public partial class UyeListeleme : Form
    {
        public UyeListeleme()
        {
            InitializeComponent();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (listUyeler.SelectedItems.Count>0)
            {
                this.Hide();
                using (UyeOnay uyeOnay=new UyeOnay())
                {
                    uyeOnay.ShowDialog();
                }
                this.Show();
            }
            else
            {
                errorProvider.SetError(btnDetay, "Hata");
            }
        }
    }
}
