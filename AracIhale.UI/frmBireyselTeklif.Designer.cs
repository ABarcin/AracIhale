
namespace AracIhale.UI
{
    partial class frmBireyselTeklif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbGenelBilgiler = new System.Windows.Forms.GroupBox();
            this.txtTeklifFiyat = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAracDetay = new System.Windows.Forms.GroupBox();
            this.nmKM = new System.Windows.Forms.NumericUpDown();
            this.cmbDonanim = new System.Windows.Forms.ComboBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.cmbVersiyon = new System.Windows.Forms.ComboBox();
            this.cmbVites = new System.Windows.Forms.ComboBox();
            this.cmbYakit = new System.Windows.Forms.ComboBox();
            this.cmbGovde = new System.Windows.Forms.ComboBox();
            this.cmbYıl = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFotolar = new System.Windows.Forms.GroupBox();
            this.gbAciklama = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTarih = new System.Windows.Forms.Button();
            this.btnTramer = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGenelBilgiler.SuspendLayout();
            this.gbAracDetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKM)).BeginInit();
            this.gbAciklama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGenelBilgiler
            // 
            this.gbGenelBilgiler.Controls.Add(this.txtTeklifFiyat);
            this.gbGenelBilgiler.Controls.Add(this.txtAdSoyad);
            this.gbGenelBilgiler.Controls.Add(this.cmbStatu);
            this.gbGenelBilgiler.Controls.Add(this.label4);
            this.gbGenelBilgiler.Controls.Add(this.label2);
            this.gbGenelBilgiler.Controls.Add(this.label1);
            this.gbGenelBilgiler.Location = new System.Drawing.Point(12, 12);
            this.gbGenelBilgiler.Name = "gbGenelBilgiler";
            this.gbGenelBilgiler.Size = new System.Drawing.Size(776, 122);
            this.gbGenelBilgiler.TabIndex = 2;
            this.gbGenelBilgiler.TabStop = false;
            this.gbGenelBilgiler.Text = "Genel Bilgiler";
            // 
            // txtTeklifFiyat
            // 
            this.txtTeklifFiyat.Location = new System.Drawing.Point(119, 70);
            this.txtTeklifFiyat.Name = "txtTeklifFiyat";
            this.txtTeklifFiyat.Size = new System.Drawing.Size(225, 20);
            this.txtTeklifFiyat.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Enabled = false;
            this.txtAdSoyad.Location = new System.Drawing.Point(119, 29);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(225, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // cmbStatu
            // 
            this.cmbStatu.Enabled = false;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(522, 29);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(225, 21);
            this.cmbStatu.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teklif Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Statü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Ad Soyad";
            // 
            // gbAracDetay
            // 
            this.gbAracDetay.Controls.Add(this.nmKM);
            this.gbAracDetay.Controls.Add(this.cmbDonanim);
            this.gbAracDetay.Controls.Add(this.cmbRenk);
            this.gbAracDetay.Controls.Add(this.cmbVersiyon);
            this.gbAracDetay.Controls.Add(this.cmbVites);
            this.gbAracDetay.Controls.Add(this.cmbYakit);
            this.gbAracDetay.Controls.Add(this.cmbGovde);
            this.gbAracDetay.Controls.Add(this.cmbYıl);
            this.gbAracDetay.Controls.Add(this.cmbModel);
            this.gbAracDetay.Controls.Add(this.cmbMarka);
            this.gbAracDetay.Controls.Add(this.label14);
            this.gbAracDetay.Controls.Add(this.label9);
            this.gbAracDetay.Controls.Add(this.label13);
            this.gbAracDetay.Controls.Add(this.label8);
            this.gbAracDetay.Controls.Add(this.label12);
            this.gbAracDetay.Controls.Add(this.label7);
            this.gbAracDetay.Controls.Add(this.label11);
            this.gbAracDetay.Controls.Add(this.label6);
            this.gbAracDetay.Controls.Add(this.label10);
            this.gbAracDetay.Controls.Add(this.label5);
            this.gbAracDetay.Enabled = false;
            this.gbAracDetay.Location = new System.Drawing.Point(12, 140);
            this.gbAracDetay.Name = "gbAracDetay";
            this.gbAracDetay.Size = new System.Drawing.Size(776, 180);
            this.gbAracDetay.TabIndex = 2;
            this.gbAracDetay.TabStop = false;
            this.gbAracDetay.Text = "Araç Detay Bilgileri";
            // 
            // nmKM
            // 
            this.nmKM.Location = new System.Drawing.Point(522, 59);
            this.nmKM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nmKM.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmKM.Name = "nmKM";
            this.nmKM.Size = new System.Drawing.Size(224, 20);
            this.nmKM.TabIndex = 2;
            // 
            // cmbDonanim
            // 
            this.cmbDonanim.BackColor = System.Drawing.Color.White;
            this.cmbDonanim.Enabled = false;
            this.cmbDonanim.ForeColor = System.Drawing.Color.White;
            this.cmbDonanim.FormattingEnabled = true;
            this.cmbDonanim.Location = new System.Drawing.Point(522, 141);
            this.cmbDonanim.Name = "cmbDonanim";
            this.cmbDonanim.Size = new System.Drawing.Size(225, 21);
            this.cmbDonanim.TabIndex = 1;
            // 
            // cmbRenk
            // 
            this.cmbRenk.BackColor = System.Drawing.Color.White;
            this.cmbRenk.Enabled = false;
            this.cmbRenk.ForeColor = System.Drawing.Color.White;
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Location = new System.Drawing.Point(119, 141);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(225, 21);
            this.cmbRenk.TabIndex = 1;
            // 
            // cmbVersiyon
            // 
            this.cmbVersiyon.BackColor = System.Drawing.Color.White;
            this.cmbVersiyon.Enabled = false;
            this.cmbVersiyon.ForeColor = System.Drawing.Color.White;
            this.cmbVersiyon.FormattingEnabled = true;
            this.cmbVersiyon.Location = new System.Drawing.Point(522, 115);
            this.cmbVersiyon.Name = "cmbVersiyon";
            this.cmbVersiyon.Size = new System.Drawing.Size(225, 21);
            this.cmbVersiyon.TabIndex = 1;
            // 
            // cmbVites
            // 
            this.cmbVites.BackColor = System.Drawing.Color.White;
            this.cmbVites.Enabled = false;
            this.cmbVites.ForeColor = System.Drawing.Color.White;
            this.cmbVites.FormattingEnabled = true;
            this.cmbVites.Location = new System.Drawing.Point(119, 115);
            this.cmbVites.Name = "cmbVites";
            this.cmbVites.Size = new System.Drawing.Size(225, 21);
            this.cmbVites.TabIndex = 1;
            // 
            // cmbYakit
            // 
            this.cmbYakit.BackColor = System.Drawing.Color.White;
            this.cmbYakit.Enabled = false;
            this.cmbYakit.ForeColor = System.Drawing.Color.White;
            this.cmbYakit.FormattingEnabled = true;
            this.cmbYakit.Location = new System.Drawing.Point(522, 87);
            this.cmbYakit.Name = "cmbYakit";
            this.cmbYakit.Size = new System.Drawing.Size(225, 21);
            this.cmbYakit.TabIndex = 1;
            // 
            // cmbGovde
            // 
            this.cmbGovde.BackColor = System.Drawing.Color.White;
            this.cmbGovde.Enabled = false;
            this.cmbGovde.ForeColor = System.Drawing.Color.White;
            this.cmbGovde.FormattingEnabled = true;
            this.cmbGovde.Location = new System.Drawing.Point(119, 87);
            this.cmbGovde.Name = "cmbGovde";
            this.cmbGovde.Size = new System.Drawing.Size(225, 21);
            this.cmbGovde.TabIndex = 1;
            // 
            // cmbYıl
            // 
            this.cmbYıl.BackColor = System.Drawing.Color.White;
            this.cmbYıl.Enabled = false;
            this.cmbYıl.ForeColor = System.Drawing.Color.White;
            this.cmbYıl.FormattingEnabled = true;
            this.cmbYıl.Location = new System.Drawing.Point(119, 59);
            this.cmbYıl.Name = "cmbYıl";
            this.cmbYıl.Size = new System.Drawing.Size(225, 21);
            this.cmbYıl.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.BackColor = System.Drawing.Color.White;
            this.cmbModel.Enabled = false;
            this.cmbModel.ForeColor = System.Drawing.Color.White;
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(522, 32);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(225, 21);
            this.cmbModel.TabIndex = 1;
            // 
            // cmbMarka
            // 
            this.cmbMarka.BackColor = System.Drawing.Color.White;
            this.cmbMarka.Enabled = false;
            this.cmbMarka.ForeColor = System.Drawing.Color.White;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(119, 32);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(225, 21);
            this.cmbMarka.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Donanım";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Renk";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(405, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Versiyon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Vites Tipi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Yakıt Tipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Gövde Tipi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "KM Bilgisi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yıl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(405, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Araç Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Araç Marka";
            // 
            // gbFotolar
            // 
            this.gbFotolar.Location = new System.Drawing.Point(12, 327);
            this.gbFotolar.Name = "gbFotolar";
            this.gbFotolar.Size = new System.Drawing.Size(379, 64);
            this.gbFotolar.TabIndex = 3;
            this.gbFotolar.TabStop = false;
            this.gbFotolar.Text = "Fotoğraflar";
            // 
            // gbAciklama
            // 
            this.gbAciklama.Controls.Add(this.label15);
            this.gbAciklama.Location = new System.Drawing.Point(409, 327);
            this.gbAciklama.Name = "gbAciklama";
            this.gbAciklama.Size = new System.Drawing.Size(379, 64);
            this.gbAciklama.TabIndex = 3;
            this.gbAciklama.TabStop = false;
            this.gbAciklama.Text = "Açıklama";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Aciklama gelecek";
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(409, 397);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(119, 23);
            this.btnTarih.TabIndex = 4;
            this.btnTarih.Text = "Araç Tarihçe";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // btnTramer
            // 
            this.btnTramer.Location = new System.Drawing.Point(534, 397);
            this.btnTramer.Name = "btnTramer";
            this.btnTramer.Size = new System.Drawing.Size(129, 23);
            this.btnTramer.TabIndex = 4;
            this.btnTramer.Text = "Tramer Bilgileri";
            this.btnTramer.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(669, 397);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(119, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmBireyselTeklif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTramer);
            this.Controls.Add(this.btnTarih);
            this.Controls.Add(this.gbAciklama);
            this.Controls.Add(this.gbFotolar);
            this.Controls.Add(this.gbAracDetay);
            this.Controls.Add(this.gbGenelBilgiler);
            this.Name = "frmBireyselTeklif";
            this.Text = "BireyselTeklif";
            this.Load += new System.EventHandler(this.frmBireyselTeklif_Load);
            this.gbGenelBilgiler.ResumeLayout(false);
            this.gbGenelBilgiler.PerformLayout();
            this.gbAracDetay.ResumeLayout(false);
            this.gbAracDetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmKM)).EndInit();
            this.gbAciklama.ResumeLayout(false);
            this.gbAciklama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGenelBilgiler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbAracDetay;
        private System.Windows.Forms.TextBox txtTeklifFiyat;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.ComboBox cmbDonanim;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.ComboBox cmbVersiyon;
        private System.Windows.Forms.ComboBox cmbVites;
        private System.Windows.Forms.ComboBox cmbYakit;
        private System.Windows.Forms.ComboBox cmbGovde;
        private System.Windows.Forms.ComboBox cmbYıl;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbFotolar;
        private System.Windows.Forms.GroupBox gbAciklama;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnTramer;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nmKM;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}