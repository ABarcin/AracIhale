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
            PrepareForm();
            lstAracListesi.Items.Clear();
            foreach (AracListVM arac in unitOfWork.AracRepository.AracListele(secilenMarka,secilenModel,secilenKullaniciTipi,secilenStatu))
            {
                ListViewItem li = new ListViewItem();
                li.Text = arac.AracID.ToString();
                li.SubItems.Add(arac.MarkaAd);
                li.SubItems.Add(arac.ModelAd);
                li.SubItems.Add(arac.KullaniciTip);
                li.SubItems.Add(arac.StatuAd);
                li.SubItems.Add(arac.CreatedDate.ToString());
                lstAracListesi.Items.Add(li);
            }
        }

        private void PrepareForm()
        {
            cmbAracMarka.Items.AddRange(unitOfWork.MarkaRepository.TumMarkalar().ToArray());
            cmbKullaniciTipi.Items.AddRange(unitOfWork.KullaniciTipRepository.KullaniciTipListele().ToArray());
            cmbStatu.Items.AddRange(unitOfWork.AracStatuRepository.StatuleriListele().ToArray());
        }
        MarkaVM secilenMarka;
        ArabaModelVM secilenModel;
        KullaniciTipVM secilenKullaniciTipi;
        StatuVM secilenStatu;
        private void btnListele_Click(object sender, EventArgs e)
        {
            if (IsValidate())
            {
                secilenMarka = cmbAracMarka.SelectedItem as MarkaVM;
                secilenModel = cmbAracModel.SelectedItem as ArabaModelVM;
                secilenKullaniciTipi = cmbKullaniciTipi.SelectedItem as KullaniciTipVM;
                secilenStatu = cmbStatu.SelectedItem as StatuVM;

                FiltrelenenAraclariListele();
            }
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
                li.SubItems.Add(arac.CreatedDate.ToString());
                lstAracListesi.Items.Add(li);
            }
        }

        private bool IsValidate()
        {
            bool isValidate = false;

            if (cmbAracMarka.SelectedIndex > -1 && cmbAracModel.SelectedIndex > -1 && cmbKullaniciTipi.SelectedIndex > -1
                && cmbStatu.SelectedIndex > -1)
            {
                isValidate = true;
            }
            return isValidate;
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
    }
}

