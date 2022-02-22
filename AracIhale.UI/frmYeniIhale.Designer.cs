
namespace AracIhale.UI
{
    partial class frmYeniIhale
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
            this.listArac = new System.Windows.Forms.ListView();
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
            this.dtIhaleBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtIhaleBitis = new System.Windows.Forms.DateTimePicker();
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
            this.myErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbIhaleArac.SuspendLayout();
            this.gbIhaleGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listArac
            // 
            this.listArac.AutoArrange = false;
            this.listArac.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listArac.Cursor = System.Windows.Forms.Cursors.Default;
            this.listArac.GridLines = true;
            this.listArac.HideSelection = false;
            this.listArac.Location = new System.Drawing.Point(9, 36);
            this.listArac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listArac.MultiSelect = false;
            this.listArac.Name = "listArac";
            this.listArac.ShowGroups = false;
            this.listArac.Size = new System.Drawing.Size(992, 233);
            this.listArac.TabIndex = 1;
            this.listArac.UseCompatibleStateImageBehavior = false;
            this.listArac.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
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
            this.btnAracEkle.Location = new System.Drawing.Point(779, 551);
            this.btnAracEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(113, 33);
            this.btnAracEkle.TabIndex = 5;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = false;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(927, 551);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 33);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gbIhaleArac
            // 
            this.gbIhaleArac.Controls.Add(this.listArac);
            this.gbIhaleArac.Location = new System.Drawing.Point(15, 246);
            this.gbIhaleArac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIhaleArac.Name = "gbIhaleArac";
            this.gbIhaleArac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIhaleArac.Size = new System.Drawing.Size(1025, 286);
            this.gbIhaleArac.TabIndex = 4;
            this.gbIhaleArac.TabStop = false;
            this.gbIhaleArac.Text = "İhale Araç Listesi";
            // 
            // gbIhaleGenel
            // 
            this.gbIhaleGenel.Controls.Add(this.dtBitisSaat);
            this.gbIhaleGenel.Controls.Add(this.dtBaslangicSaat);
            this.gbIhaleGenel.Controls.Add(this.dtIhaleBaslangic);
            this.gbIhaleGenel.Controls.Add(this.dtIhaleBitis);
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
            this.gbIhaleGenel.Location = new System.Drawing.Point(15, 12);
            this.gbIhaleGenel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIhaleGenel.Name = "gbIhaleGenel";
            this.gbIhaleGenel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIhaleGenel.Size = new System.Drawing.Size(1025, 193);
            this.gbIhaleGenel.TabIndex = 3;
            this.gbIhaleGenel.TabStop = false;
            this.gbIhaleGenel.Text = "İhale Genel Bilgiler";
            // 
            // dtBitisSaat
            // 
            this.dtBitisSaat.CustomFormat = "\"HH:mm\"";
            this.dtBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBitisSaat.Location = new System.Drawing.Point(529, 139);
            this.dtBitisSaat.Margin = new System.Windows.Forms.Padding(4);
            this.dtBitisSaat.Name = "dtBitisSaat";
            this.dtBitisSaat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtBitisSaat.ShowUpDown = true;
            this.dtBitisSaat.Size = new System.Drawing.Size(189, 22);
            this.dtBitisSaat.TabIndex = 18;
            // 
            // dtBaslangicSaat
            // 
            this.dtBaslangicSaat.CustomFormat = "\"HH:mm\"";
            this.dtBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBaslangicSaat.Location = new System.Drawing.Point(133, 142);
            this.dtBaslangicSaat.Margin = new System.Windows.Forms.Padding(4);
            this.dtBaslangicSaat.Name = "dtBaslangicSaat";
            this.dtBaslangicSaat.ShowUpDown = true;
            this.dtBaslangicSaat.Size = new System.Drawing.Size(189, 22);
            this.dtBaslangicSaat.TabIndex = 18;
            // 
            // dtIhaleBaslangic
            // 
            this.dtIhaleBaslangic.Location = new System.Drawing.Point(133, 91);
            this.dtIhaleBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtIhaleBaslangic.Name = "dtIhaleBaslangic";
            this.dtIhaleBaslangic.Size = new System.Drawing.Size(189, 22);
            this.dtIhaleBaslangic.TabIndex = 17;
            // 
            // dtIhaleBitis
            // 
            this.dtIhaleBitis.Location = new System.Drawing.Point(529, 91);
            this.dtIhaleBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtIhaleBitis.Name = "dtIhaleBitis";
            this.dtIhaleBitis.Size = new System.Drawing.Size(189, 22);
            this.dtIhaleBitis.TabIndex = 17;
            // 
            // cmbStatu
            // 
            this.cmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(835, 95);
            this.cmbStatu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(167, 24);
            this.cmbStatu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Statü:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Bitiş Saati:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bitiş Tarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Başlangıç Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Başlangıç Saat:";
            // 
            // cmbUyeTip
            // 
            this.cmbUyeTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyeTip.FormattingEnabled = true;
            this.cmbUyeTip.Location = new System.Drawing.Point(529, 50);
            this.cmbUyeTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUyeTip.Name = "cmbUyeTip";
            this.cmbUyeTip.Size = new System.Drawing.Size(189, 24);
            this.cmbUyeTip.TabIndex = 7;
            // 
            // cmbSirketAdi
            // 
            this.cmbSirketAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSirketAdi.FormattingEnabled = true;
            this.cmbSirketAdi.Location = new System.Drawing.Point(835, 47);
            this.cmbSirketAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSirketAdi.Name = "cmbSirketAdi";
            this.cmbSirketAdi.Size = new System.Drawing.Size(167, 24);
            this.cmbSirketAdi.TabIndex = 8;
            // 
            // txtIhaleAdi
            // 
            this.txtIhaleAdi.Location = new System.Drawing.Point(133, 48);
            this.txtIhaleAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIhaleAdi.Name = "txtIhaleAdi";
            this.txtIhaleAdi.Size = new System.Drawing.Size(189, 22);
            this.txtIhaleAdi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şirket Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bireysel/Kurumsal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "İhale Adı:";
            // 
            // myErrorProvider
            // 
            this.myErrorProvider.ContainerControl = this;
            // 
            // frmYeniIhale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 603);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbIhaleArac);
            this.Controls.Add(this.gbIhaleGenel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmYeniIhale";
            this.Text = "YeniIhale";
            this.Load += new System.EventHandler(this.YeniIhale_Load);
            this.VisibleChanged += new System.EventHandler(this.OnVisible_VisibleChanged);
            this.gbIhaleArac.ResumeLayout(false);
            this.gbIhaleGenel.ResumeLayout(false);
            this.gbIhaleGenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myErrorProvider)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtIhaleBaslangic;
        private System.Windows.Forms.DateTimePicker dtIhaleBitis;
        private System.Windows.Forms.DateTimePicker dtBitisSaat;
        private System.Windows.Forms.DateTimePicker dtBaslangicSaat;
        private System.Windows.Forms.ListView listArac;
        private System.Windows.Forms.ErrorProvider myErrorProvider;
    }
}