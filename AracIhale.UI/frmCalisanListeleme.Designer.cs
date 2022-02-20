
namespace AracIhale.UI
{
    partial class frmCalisanListeleme
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
            this.listCalisanlar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCalisanlar
            // 
            this.listCalisanlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listCalisanlar.FullRowSelect = true;
            this.listCalisanlar.GridLines = true;
            this.listCalisanlar.HideSelection = false;
            this.listCalisanlar.Location = new System.Drawing.Point(13, 13);
            this.listCalisanlar.MultiSelect = false;
            this.listCalisanlar.Name = "listCalisanlar";
            this.listCalisanlar.Size = new System.Drawing.Size(704, 290);
            this.listCalisanlar.TabIndex = 0;
            this.listCalisanlar.UseCompatibleStateImageBehavior = false;
            this.listCalisanlar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ad Soyad";
            this.columnHeader1.Width = 291;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rol";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Aktiflik Durumu";
            this.columnHeader3.Width = 260;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(92, 309);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(521, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Calisan Ekle / Bilgileri Güncelle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmCalisanListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 404);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listCalisanlar);
            this.Name = "frmCalisanListeleme";
            this.Text = "CalisanListeleme";
            this.Load += new System.EventHandler(this.KullaniciListeleme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listCalisanlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}