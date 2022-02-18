
namespace AracIhale.UI
{
    partial class YeniIhale
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
            System.Windows.Forms.ListView listArac;
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.gbIhaleArac = new System.Windows.Forms.GroupBox();
            this.gbIhaleGenel = new System.Windows.Forms.GroupBox();
            this.dtBitisSaat = new System.Windows.Forms.DateTimePicker();
            this.dtBaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.dtIhaleBitis = new System.Windows.Forms.DateTimePicker();
            this.dtIhaleBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUyeTip = new System.Windows.Forms.ComboBox();
            this.cmbSirketAdi = new System.Windows.Forms.ComboBox();
            this.txtIhaleAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            listArac = new System.Windows.Forms.ListView();
            this.gbIhaleArac.SuspendLayout();
            this.gbIhaleGenel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listArac
            // 
            listArac.AutoArrange = false;
            listArac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            listArac.Cursor = System.Windows.Forms.Cursors.Default;
            listArac.GridLines = true;
            listArac.HideSelection = false;
            listArac.Location = new System.Drawing.Point(7, 29);
            listArac.Margin = new System.Windows.Forms.Padding(2);
            listArac.Name = "listArac";
            listArac.ShowGroups = false;
            listArac.Size = new System.Drawing.Size(745, 190);
            listArac.TabIndex = 1;
            listArac.UseCompatibleStateImageBehavior = false;
            listArac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Araç id";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Araç Marka";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Araç Model";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bireysel/Kurumsal";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Statü";
            this.columnHeader5.Width = 49;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kaydeden Kullanıcı";
            this.columnHeader6.Width = 129;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kaydetme Zamanı";
            this.columnHeader7.Width = 124;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyat";
            this.columnHeader8.Width = 65;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.BackColor = System.Drawing.Color.White;
            this.btnAracEkle.Location = new System.Drawing.Point(584, 448);
            this.btnAracEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(85, 27);
            this.btnAracEkle.TabIndex = 5;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(695, 448);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(67, 27);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gbIhaleArac
            // 
            this.gbIhaleArac.Controls.Add(listArac);
            this.gbIhaleArac.Location = new System.Drawing.Point(11, 200);
            this.gbIhaleArac.Margin = new System.Windows.Forms.Padding(2);
            this.gbIhaleArac.Name = "gbIhaleArac";
            this.gbIhaleArac.Padding = new System.Windows.Forms.Padding(2);
            this.gbIhaleArac.Size = new System.Drawing.Size(769, 232);
            this.gbIhaleArac.TabIndex = 4;
            this.gbIhaleArac.TabStop = false;
            this.gbIhaleArac.Text = "İhale Araç Listesi";
            // 
            // gbIhaleGenel
            // 
            this.gbIhaleGenel.Controls.Add(this.dtBitisSaat);
            this.gbIhaleGenel.Controls.Add(this.dtBaslangicSaat);
            this.gbIhaleGenel.Controls.Add(this.dtIhaleBitis);
            this.gbIhaleGenel.Controls.Add(this.dtIhaleBaslangic);
            this.gbIhaleGenel.Controls.Add(this.cmbStatu);
            this.gbIhaleGenel.Controls.Add(this.label3);
            this.gbIhaleGenel.Controls.Add(this.label8);
            this.gbIhaleGenel.Controls.Add(this.label7);
            this.gbIhaleGenel.Controls.Add(this.label6);
            this.gbIhaleGenel.Controls.Add(this.label5);
            this.gbIhaleGenel.Controls.Add(this.cmbUyeTip);
            this.gbIhaleGenel.Controls.Add(this.cmbSirketAdi);
            this.gbIhaleGenel.Controls.Add(this.txtIhaleAdi);
            this.gbIhaleGenel.Controls.Add(this.label4);
            this.gbIhaleGenel.Controls.Add(this.label2);
            this.gbIhaleGenel.Controls.Add(this.label1);
            this.gbIhaleGenel.Location = new System.Drawing.Point(11, 10);
            this.gbIhaleGenel.Margin = new System.Windows.Forms.Padding(2);
            this.gbIhaleGenel.Name = "gbIhaleGenel";
            this.gbIhaleGenel.Padding = new System.Windows.Forms.Padding(2);
            this.gbIhaleGenel.Size = new System.Drawing.Size(769, 157);
            this.gbIhaleGenel.TabIndex = 3;
            this.gbIhaleGenel.TabStop = false;
            this.gbIhaleGenel.Text = "İhale Genel Bilgiler";
            // 
            // dtBitisSaat
            // 
            this.dtBitisSaat.CustomFormat = "\"HH:mm\"";
            this.dtBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBitisSaat.Location = new System.Drawing.Point(397, 113);
            this.dtBitisSaat.Name = "dtBitisSaat";
            this.dtBitisSaat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtBitisSaat.ShowUpDown = true;
            this.dtBitisSaat.Size = new System.Drawing.Size(143, 20);
            this.dtBitisSaat.TabIndex = 18;
            // 
            // dtBaslangicSaat
            // 
            this.dtBaslangicSaat.CustomFormat = "\"HH:mm\"";
            this.dtBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBaslangicSaat.Location = new System.Drawing.Point(100, 115);
            this.dtBaslangicSaat.Name = "dtBaslangicSaat";
            this.dtBaslangicSaat.ShowUpDown = true;
            this.dtBaslangicSaat.Size = new System.Drawing.Size(143, 20);
            this.dtBaslangicSaat.TabIndex = 18;
            // 
            // dtIhaleBitis
            // 
            this.dtIhaleBitis.Location = new System.Drawing.Point(100, 74);
            this.dtIhaleBitis.Name = "dtIhaleBitis";
            this.dtIhaleBitis.Size = new System.Drawing.Size(143, 20);
            this.dtIhaleBitis.TabIndex = 17;
            // 
            // dtIhaleBaslangic
            // 
            this.dtIhaleBaslangic.Location = new System.Drawing.Point(397, 74);
            this.dtIhaleBaslangic.Name = "dtIhaleBaslangic";
            this.dtIhaleBaslangic.Size = new System.Drawing.Size(143, 20);
            this.dtIhaleBaslangic.TabIndex = 17;
            // 
            // cmbStatu
            // 
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(626, 77);
            this.cmbStatu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(126, 21);
            this.cmbStatu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bitiş Saati:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bitiş Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Başlangıç Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Başlangıç Saat:";
            // 
            // cmbUyeTip
            // 
            this.cmbUyeTip.FormattingEnabled = true;
            this.cmbUyeTip.Location = new System.Drawing.Point(397, 41);
            this.cmbUyeTip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUyeTip.Name = "cmbUyeTip";
            this.cmbUyeTip.Size = new System.Drawing.Size(143, 21);
            this.cmbUyeTip.TabIndex = 7;
            // 
            // cmbSirketAdi
            // 
            this.cmbSirketAdi.FormattingEnabled = true;
            this.cmbSirketAdi.Location = new System.Drawing.Point(626, 38);
            this.cmbSirketAdi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSirketAdi.Name = "cmbSirketAdi";
            this.cmbSirketAdi.Size = new System.Drawing.Size(126, 21);
            this.cmbSirketAdi.TabIndex = 8;
            // 
            // txtIhaleAdi
            // 
            this.txtIhaleAdi.Location = new System.Drawing.Point(100, 39);
            this.txtIhaleAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtIhaleAdi.Name = "txtIhaleAdi";
            this.txtIhaleAdi.Size = new System.Drawing.Size(143, 20);
            this.txtIhaleAdi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şirket Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bireysel/Kurumsal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "İhale Adı:";
            // 
            // YeniIhale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 490);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbIhaleArac);
            this.Controls.Add(this.gbIhaleGenel);
            this.Name = "YeniIhale";
            this.Text = "YeniIhale";
            this.gbIhaleArac.ResumeLayout(false);
            this.gbIhaleGenel.ResumeLayout(false);
            this.gbIhaleGenel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox gbIhaleArac;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.GroupBox gbIhaleGenel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUyeTip;
        private System.Windows.Forms.ComboBox cmbSirketAdi;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.TextBox txtIhaleAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtIhaleBitis;
        private System.Windows.Forms.DateTimePicker dtIhaleBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitisSaat;
        private System.Windows.Forms.DateTimePicker dtBaslangicSaat;
    }
}