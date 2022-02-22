
namespace AracIhale.UI
{
    partial class frmAracTanimlamaListeleme
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
            this.grpGenel = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.grpAracListesi = new System.Windows.Forms.GroupBox();
            this.lstAracListesi = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpKriterler = new System.Windows.Forms.GroupBox();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.cmbKullaniciTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAracModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAracMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGenel.SuspendLayout();
            this.grpAracListesi.SuspendLayout();
            this.grpKriterler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGenel
            // 
            this.grpGenel.Controls.Add(this.btnYeni);
            this.grpGenel.Controls.Add(this.btnGuncelle);
            this.grpGenel.Controls.Add(this.btnSil);
            this.grpGenel.Controls.Add(this.btnTemizle);
            this.grpGenel.Controls.Add(this.btnListele);
            this.grpGenel.Controls.Add(this.grpAracListesi);
            this.grpGenel.Controls.Add(this.grpKriterler);
            this.grpGenel.Location = new System.Drawing.Point(12, 12);
            this.grpGenel.Name = "grpGenel";
            this.grpGenel.Size = new System.Drawing.Size(790, 475);
            this.grpGenel.TabIndex = 0;
            this.grpGenel.TabStop = false;
            this.grpGenel.Text = "Araç Tanımlama/Listeleme";
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(547, 441);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 2;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(628, 441);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(709, 441);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(628, 100);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(709, 100);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // grpAracListesi
            // 
            this.grpAracListesi.Controls.Add(this.lstAracListesi);
            this.grpAracListesi.Location = new System.Drawing.Point(6, 142);
            this.grpAracListesi.Name = "grpAracListesi";
            this.grpAracListesi.Size = new System.Drawing.Size(778, 293);
            this.grpAracListesi.TabIndex = 1;
            this.grpAracListesi.TabStop = false;
            this.grpAracListesi.Text = "Araç Listesi";
            // 
            // lstAracListesi
            // 
            this.lstAracListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstAracListesi.FullRowSelect = true;
            this.lstAracListesi.GridLines = true;
            this.lstAracListesi.HideSelection = false;
            this.lstAracListesi.Location = new System.Drawing.Point(6, 19);
            this.lstAracListesi.MultiSelect = false;
            this.lstAracListesi.Name = "lstAracListesi";
            this.lstAracListesi.Size = new System.Drawing.Size(766, 268);
            this.lstAracListesi.TabIndex = 0;
            this.lstAracListesi.UseCompatibleStateImageBehavior = false;
            this.lstAracListesi.View = System.Windows.Forms.View.Details;
            this.lstAracListesi.SelectedIndexChanged += new System.EventHandler(this.lstAracListesi_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Araç Marka";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Araç Model";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bireysel/Kurumsal";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Statü";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kaydeden Kullanıcı";
            this.columnHeader6.Width = 150;
            // 
            // grpKriterler
            // 
            this.grpKriterler.Controls.Add(this.cmbStatu);
            this.grpKriterler.Controls.Add(this.cmbKullaniciTipi);
            this.grpKriterler.Controls.Add(this.label4);
            this.grpKriterler.Controls.Add(this.cmbAracModel);
            this.grpKriterler.Controls.Add(this.label3);
            this.grpKriterler.Controls.Add(this.cmbAracMarka);
            this.grpKriterler.Controls.Add(this.label2);
            this.grpKriterler.Controls.Add(this.label1);
            this.grpKriterler.Location = new System.Drawing.Point(6, 34);
            this.grpKriterler.Name = "grpKriterler";
            this.grpKriterler.Size = new System.Drawing.Size(778, 50);
            this.grpKriterler.TabIndex = 0;
            this.grpKriterler.TabStop = false;
            this.grpKriterler.Text = "Kriterler";
            // 
            // cmbStatu
            // 
            this.cmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(641, 19);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(121, 21);
            this.cmbStatu.TabIndex = 1;
            // 
            // cmbKullaniciTipi
            // 
            this.cmbKullaniciTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullaniciTipi.FormattingEnabled = true;
            this.cmbKullaniciTipi.Location = new System.Drawing.Point(473, 18);
            this.cmbKullaniciTipi.Name = "cmbKullaniciTipi";
            this.cmbKullaniciTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbKullaniciTipi.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Statü:";
            // 
            // cmbAracModel
            // 
            this.cmbAracModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracModel.FormattingEnabled = true;
            this.cmbAracModel.Location = new System.Drawing.Point(246, 19);
            this.cmbAracModel.Name = "cmbAracModel";
            this.cmbAracModel.Size = new System.Drawing.Size(121, 21);
            this.cmbAracModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bireysel/Kurumsal:";
            // 
            // cmbAracMarka
            // 
            this.cmbAracMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAracMarka.FormattingEnabled = true;
            this.cmbAracMarka.Location = new System.Drawing.Point(74, 19);
            this.cmbAracMarka.Name = "cmbAracMarka";
            this.cmbAracMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbAracMarka.TabIndex = 1;
            this.cmbAracMarka.SelectedIndexChanged += new System.EventHandler(this.cmbAracMarka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Marka:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAracTanimlamaListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 495);
            this.Controls.Add(this.grpGenel);
            this.Name = "frmAracTanimlamaListeleme";
            this.Text = "Araç Tanımlama/Listeleme Ekranı";
            this.Load += new System.EventHandler(this.AracTanimlama_Load);
            this.grpGenel.ResumeLayout(false);
            this.grpAracListesi.ResumeLayout(false);
            this.grpKriterler.ResumeLayout(false);
            this.grpKriterler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenel;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox grpAracListesi;
        private System.Windows.Forms.ListView lstAracListesi;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox grpKriterler;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.ComboBox cmbKullaniciTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAracModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAracMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

