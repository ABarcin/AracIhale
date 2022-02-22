using AracIhale.DAL.Repositories.Concrete;
using AracIhale.MODEL.Model.Context;
using AracIhale.MODEL.VM;
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
    public partial class frmCalisanListeleme : Form
    {
        AracIhaleEntities _context = new AracIhaleEntities();

        public frmCalisanListeleme()
        {
            InitializeComponent();
        }

        //burak
        private void KullaniciListeleme_Load(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void CalisanListele()
        {
            listCalisanlar.Items.Clear();
            CalisanRepository calisanRepository = new CalisanRepository(_context);
            RolRepository rolRepository = new RolRepository(_context);

            List<CalisanVM> calisanList = calisanRepository.CalisanListesiGetir();


            foreach (CalisanVM item in calisanList)
            {
                ListViewItem listView = new ListViewItem();
                listView.Text = item.Ad + " " + item.Soyad;
                listView.SubItems.Add(rolRepository.RolAdiGetir(item.RolID));

                if (item.AktiflikDurumu == true)
                {
                    listView.SubItems.Add("Aktif");
                }
                else
                {
                    listView.SubItems.Add("Pasif");
                }

                listCalisanlar.Items.Add(listView);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (frmCalisanKayit frmCalisanKayit=new frmCalisanKayit())
            {
                frmCalisanKayit.ShowDialog();
            }
            CalisanListele();
            this.Show();
        }
    }
}
