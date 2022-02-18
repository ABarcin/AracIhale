
namespace AracIhale.UI
{
    partial class IhaleListeleme
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
            this.gbIhaleListeleme = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listIhaleler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbUyeTipi = new System.Windows.Forms.ComboBox();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.txtIhaleAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbIhaleListeleme.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIhaleListeleme
            // 
            this.gbIhaleListeleme.Controls.Add(this.btnSil);
            this.gbIhaleListeleme.Controls.Add(this.btnGuncelle);
            this.gbIhaleListeleme.Controls.Add(this.btnYeni);
            this.gbIhaleListeleme.Controls.Add(this.groupBox3);
            this.gbIhaleListeleme.Controls.Add(this.btnListele);
            this.gbIhaleListeleme.Controls.Add(this.groupBox2);
            this.gbIhaleListeleme.Location = new System.Drawing.Point(20, 5);
            this.gbIhaleListeleme.Margin = new System.Windows.Forms.Padding(2);
            this.gbIhaleListeleme.Name = "gbIhaleListeleme";
            this.gbIhaleListeleme.Padding = new System.Windows.Forms.Padding(2);
            this.gbIhaleListeleme.Size = new System.Drawing.Size(761, 441);
            this.gbIhaleListeleme.TabIndex = 1;
            this.gbIhaleListeleme.TabStop = false;
            this.gbIhaleListeleme.Text = "Araç Tanımlama/Listeleme";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(688, 404);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 22);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(588, 404);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(71, 22);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(501, 404);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(2);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(64, 22);
            this.btnYeni.TabIndex = 5;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listIhaleler);
            this.groupBox3.Location = new System.Drawing.Point(18, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(739, 211);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İhale Listesi";
            // 
            // listIhaleler
            // 
            this.listIhaleler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listIhaleler.Cursor = System.Windows.Forms.Cursors.Default;
            this.listIhaleler.FullRowSelect = true;
            this.listIhaleler.GridLines = true;
            this.listIhaleler.HideSelection = false;
            this.listIhaleler.Location = new System.Drawing.Point(4, 21);
            this.listIhaleler.Margin = new System.Windows.Forms.Padding(2);
            this.listIhaleler.Name = "listIhaleler";
            this.listIhaleler.Size = new System.Drawing.Size(731, 190);
            this.listIhaleler.TabIndex = 0;
            this.listIhaleler.UseCompatibleStateImageBehavior = false;
            this.listIhaleler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İhale id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İhale Adı";
            this.columnHeader2.Width = 92;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bireysel/Kurumsal";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İhale Başlangıç";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İhale Bitiş";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Statü";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kaydeden Kullanıcı";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kaydetme Zamanı";
            this.columnHeader8.Width = 163;
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.White;
            this.btnListele.Location = new System.Drawing.Point(688, 135);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(64, 22);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbUyeTipi);
            this.groupBox2.Controls.Add(this.cmbStatu);
            this.groupBox2.Controls.Add(this.txtIhaleAdi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 36);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(739, 75);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kriterler";
            // 
            // cmbUyeTipi
            // 
            this.cmbUyeTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyeTipi.FormattingEnabled = true;
            this.cmbUyeTipi.Location = new System.Drawing.Point(350, 28);
            this.cmbUyeTipi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUyeTipi.Name = "cmbUyeTipi";
            this.cmbUyeTipi.Size = new System.Drawing.Size(129, 21);
            this.cmbUyeTipi.TabIndex = 2;
            // 
            // cmbStatu
            // 
            this.cmbStatu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(592, 29);
            this.cmbStatu.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(135, 21);
            this.cmbStatu.TabIndex = 2;
            // 
            // txtIhaleAdi
            // 
            this.txtIhaleAdi.Location = new System.Drawing.Point(65, 27);
            this.txtIhaleAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtIhaleAdi.Name = "txtIhaleAdi";
            this.txtIhaleAdi.Size = new System.Drawing.Size(120, 20);
            this.txtIhaleAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Statü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bireysel/Kurumsal:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İhale Adı:";
            // 
            // IhaleListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.gbIhaleListeleme);
            this.Name = "IhaleListeleme";
            this.Text = "IhaleListeleme";
            this.Load += new System.EventHandler(this.IhaleListeleme_Load);
            this.gbIhaleListeleme.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIhaleListeleme;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listIhaleler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbUyeTipi;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.TextBox txtIhaleAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}