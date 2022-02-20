using AracIhale.DAL.UnitOfWork;
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
    public partial class AracTanimlamaListeleme : Form
    {
        public AracTanimlamaListeleme()
        {
            InitializeComponent();
        }
        UnitOfWork unitOfWork = new UnitOfWork(new AracIhaleEntities());
        private void AracTanimlama_Load(object sender, EventArgs e)
        {
            
            lstAracListesi.Items.Clear();
            PrepareForm();
        }



        private void PrepareForm()
        {
            cmbAracMarka.Items.AddRange(unitOfWork.MarkaRepository.TumMarkalar().ToArray());
            cmbKullaniciTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            cmbStatu.Items.AddRange(unitOfWork.AracStatuRepository.StatuleriListele().ToArray());
            FiltrelenenAraclariListele();


        }
        string secilenMarka;
        string secilenModel;
        string secilenKullaniciTipi;
        string secilenStatu;
        private void btnListele_Click(object sender, EventArgs e)
        {
            secilenMarka = cmbAracMarka.SelectedItem == null ? null : cmbAracMarka.SelectedItem.ToString();
            secilenModel = cmbAracModel.SelectedItem == null ? null : cmbAracModel.SelectedItem.ToString();
            secilenKullaniciTipi = cmbKullaniciTipi.SelectedItem == null ? null : cmbKullaniciTipi.SelectedItem.ToString();
            secilenStatu = cmbStatu.SelectedItem == null ? null : cmbStatu.SelectedItem.ToString();
            FiltrelenenAraclariListele();
        }

        private void FiltrelenenAraclariListele()
        {
            lstAracListesi.Items.Clear();
            foreach (AracListVM arac in unitOfWork.AracRepository.AracListele(secilenMarka, secilenModel, secilenKullaniciTipi, secilenStatu))
            {
                ListViewItem li = new ListViewItem();
                li.Text = arac.AracID.ToString();
                li.SubItems.Add(arac.MarkaAd);
                li.SubItems.Add(arac.ModelAd);
                li.SubItems.Add(arac.KullaniciTip);
                li.SubItems.Add(arac.StatuAd);
                li.SubItems.Add(arac.KullaniciAd);
                lstAracListesi.Items.Add(li);
            }
        }

        private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListModelsByMarka();
        }

        private void ListModelsByMarka()
        {
            cmbAracModel.Items.Clear();
            cmbAracModel.Items.AddRange(unitOfWork.ArabaModelRepository.ModelListele(cmbAracMarka.SelectedItem as MarkaVM).ToArray());
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AracDetayBilgi aracDetayBilgi = new AracDetayBilgi())
            {
                aracDetayBilgi.ShowDialog();
            }
            this.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FiltreleriTemizle();
        }

        private void FiltreleriTemizle()
        {
            cmbAracMarka.SelectedIndex = 0;
            cmbAracModel.SelectedIndex = cmbKullaniciTipi.SelectedIndex = cmbStatu.SelectedIndex = -1; ;
            secilenMarka = secilenModel = secilenKullaniciTipi = secilenStatu = null;
            FiltrelenenAraclariListele();

        }
    }
}

