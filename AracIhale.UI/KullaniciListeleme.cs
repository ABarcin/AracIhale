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
    public partial class KullaniciListeleme : Form
    {
        AracIhaleEntities _context = new AracIhaleEntities();

        public KullaniciListeleme()
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

            List<CalisanVM> xd = calisanRepository.CalisanListesiGetir();


            foreach (CalisanVM item in xd)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Ad + " " + item.Soyad;
                lvi.SubItems.Add(rolRepository.RolAdiGetir(item.RolID));

                if (item.AktiflikDurumu == true)
                {
                    lvi.SubItems.Add("Aktif");
                }
                else
                {
                    lvi.SubItems.Add("Pasif");
                }

                listCalisanlar.Items.Add(lvi);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (CalisanKayit calisanKayit=new CalisanKayit())
            {
                calisanKayit.ShowDialog();
            }
            CalisanListele();
            this.Show();
        }
    }
}
