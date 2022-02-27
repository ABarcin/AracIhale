
namespace AracIhale.UI
{
    partial class frmKullaniciKayit
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
            this.cbKvkk = new System.Windows.Forms.CheckBox();
            this.cbUyelik = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbKullaniciTip = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFirma = new System.Windows.Forms.GroupBox();
            this.cmbFirmaAd = new System.Windows.Forms.ComboBox();
            this.cmbFirmaTip = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sozlesmeMetni = new System.Windows.Forms.Label();
            this.kvkkMetni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbFirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbKvkk
            // 
            this.cbKvkk.AutoSize = true;
            this.cbKvkk.Enabled = false;
            this.cbKvkk.Location = new System.Drawing.Point(375, 257);
            this.cbKvkk.Name = "cbKvkk";
            this.cbKvkk.Size = new System.Drawing.Size(15, 14);
            this.cbKvkk.TabIndex = 19;
            this.cbKvkk.UseVisualStyleBackColor = true;
            // 
            // cbUyelik
            // 
            this.cbUyelik.AutoSize = true;
            this.cbUyelik.Enabled = false;
            this.cbUyelik.Location = new System.Drawing.Point(375, 231);
            this.cbUyelik.Name = "cbUyelik";
            this.cbUyelik.Size = new System.Drawing.Size(15, 14);
            this.cbUyelik.TabIndex = 18;
            this.cbUyelik.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(76, 379);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(314, 23);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "Kayıt Ol";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(184, 194);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(206, 20);
            this.txtSifreTekrar.TabIndex = 12;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(184, 168);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(206, 20);
            this.txtSifre.TabIndex = 13;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(184, 66);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(206, 20);
            this.txtSoyad.TabIndex = 14;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(184, 93);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(206, 20);
            this.txtKullaniciAdi.TabIndex = 15;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(184, 39);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(206, 20);
            this.txtAd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kullanıcı Verileri Koruma Kanunu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Üyelik Sözleşmesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Şifre (Tekrar)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(82, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Kullanıcı Tipi";
            // 
            // cmbKullaniciTip
            // 
            this.cmbKullaniciTip.FormattingEnabled = true;
            this.cmbKullaniciTip.Location = new System.Drawing.Point(184, 130);
            this.cmbKullaniciTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbKullaniciTip.Name = "cmbKullaniciTip";
            this.cmbKullaniciTip.Size = new System.Drawing.Size(206, 21);
            this.cmbKullaniciTip.TabIndex = 23;
            this.cmbKullaniciTip.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciTip_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbFirma
            // 
            this.gbFirma.Controls.Add(this.cmbFirmaAd);
            this.gbFirma.Controls.Add(this.cmbFirmaTip);
            this.gbFirma.Controls.Add(this.label9);
            this.gbFirma.Controls.Add(this.label10);
            this.gbFirma.Location = new System.Drawing.Point(76, 285);
            this.gbFirma.Margin = new System.Windows.Forms.Padding(2);
            this.gbFirma.Name = "gbFirma";
            this.gbFirma.Padding = new System.Windows.Forms.Padding(2);
            this.gbFirma.Size = new System.Drawing.Size(313, 75);
            this.gbFirma.TabIndex = 24;
            this.gbFirma.TabStop = false;
            this.gbFirma.Visible = false;
            // 
            // cmbFirmaAd
            // 
            this.cmbFirmaAd.FormattingEnabled = true;
            this.cmbFirmaAd.Location = new System.Drawing.Point(105, 15);
            this.cmbFirmaAd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFirmaAd.Name = "cmbFirmaAd";
            this.cmbFirmaAd.Size = new System.Drawing.Size(206, 21);
            this.cmbFirmaAd.TabIndex = 32;
            // 
            // cmbFirmaTip
            // 
            this.cmbFirmaTip.FormattingEnabled = true;
            this.cmbFirmaTip.Location = new System.Drawing.Point(105, 51);
            this.cmbFirmaTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFirmaTip.Name = "cmbFirmaTip";
            this.cmbFirmaTip.Size = new System.Drawing.Size(206, 21);
            this.cmbFirmaTip.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Firma Tipi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Firma Adı";
            // 
            // sozlesmeMetni
            // 
            this.sozlesmeMetni.AutoSize = true;
            this.sozlesmeMetni.ForeColor = System.Drawing.Color.Blue;
            this.sozlesmeMetni.Location = new System.Drawing.Point(288, 232);
            this.sozlesmeMetni.Name = "sozlesmeMetni";
            this.sozlesmeMetni.Size = new System.Drawing.Size(81, 13);
            this.sozlesmeMetni.TabIndex = 25;
            this.sozlesmeMetni.Text = "Sözleşme Metni";
            this.sozlesmeMetni.Click += new System.EventHandler(this.sozlesmeMetni_Click);
            // 
            // kvkkMetni
            // 
            this.kvkkMetni.AutoSize = true;
            this.kvkkMetni.ForeColor = System.Drawing.Color.Blue;
            this.kvkkMetni.Location = new System.Drawing.Point(305, 258);
            this.kvkkMetni.Name = "kvkkMetni";
            this.kvkkMetni.Size = new System.Drawing.Size(64, 13);
            this.kvkkMetni.TabIndex = 25;
            this.kvkkMetni.Text = "KVKK Metni";
            this.kvkkMetni.Click += new System.EventHandler(this.kvkkMetni_Click);
            // 
            // frmKullaniciKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 436);
            this.Controls.Add(this.kvkkMetni);
            this.Controls.Add(this.sozlesmeMetni);
            this.Controls.Add(this.gbFirma);
            this.Controls.Add(this.cmbKullaniciTip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbKvkk);
            this.Controls.Add(this.cbUyelik);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmKullaniciKayit";
            this.Text = "Kullanıcı Kayıt";
            this.Load += new System.EventHandler(this.frmKullaniciKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbFirma.ResumeLayout(false);
            this.gbFirma.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbKvkk;
        private System.Windows.Forms.CheckBox cbUyelik;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbKullaniciTip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox gbFirma;
        private System.Windows.Forms.ComboBox cmbFirmaAd;
        private System.Windows.Forms.ComboBox cmbFirmaTip;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label kvkkMetni;
        private System.Windows.Forms.Label sozlesmeMetni;
    }
}