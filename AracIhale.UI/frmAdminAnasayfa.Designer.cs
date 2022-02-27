
namespace AracIhale.UI
{
    partial class frmAdminAnasayfa
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
            this.btnKullaniciIslemleri = new System.Windows.Forms.Button();
            this.btnAraclslemleri = new System.Windows.Forms.Button();
            this.btnIhaleIslemleri = new System.Windows.Forms.Button();
            this.btnUyeListeleme = new System.Windows.Forms.Button();
            this.btnYetkiTanimlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciIslemleri
            // 
            this.btnKullaniciIslemleri.Location = new System.Drawing.Point(272, 115);
            this.btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            this.btnKullaniciIslemleri.Size = new System.Drawing.Size(190, 23);
            this.btnKullaniciIslemleri.TabIndex = 0;
            this.btnKullaniciIslemleri.Text = "KullaniciIslemleri";
            this.btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            this.btnKullaniciIslemleri.Click += new System.EventHandler(this.btnKullaniciIslemleri_Click);
            // 
            // btnAraclslemleri
            // 
            this.btnAraclslemleri.Location = new System.Drawing.Point(272, 144);
            this.btnAraclslemleri.Name = "btnAraclslemleri";
            this.btnAraclslemleri.Size = new System.Drawing.Size(190, 23);
            this.btnAraclslemleri.TabIndex = 0;
            this.btnAraclslemleri.Text = "AracIslemleri";
            this.btnAraclslemleri.UseVisualStyleBackColor = true;
            this.btnAraclslemleri.Click += new System.EventHandler(this.btnAraclslemleri_Click);
            // 
            // btnIhaleIslemleri
            // 
            this.btnIhaleIslemleri.Location = new System.Drawing.Point(272, 173);
            this.btnIhaleIslemleri.Name = "btnIhaleIslemleri";
            this.btnIhaleIslemleri.Size = new System.Drawing.Size(190, 23);
            this.btnIhaleIslemleri.TabIndex = 0;
            this.btnIhaleIslemleri.Text = "IhaleIslemleri";
            this.btnIhaleIslemleri.UseVisualStyleBackColor = true;
            this.btnIhaleIslemleri.Click += new System.EventHandler(this.btnIhaleIslemleri_Click);
            // 
            // btnUyeListeleme
            // 
            this.btnUyeListeleme.Location = new System.Drawing.Point(272, 202);
            this.btnUyeListeleme.Name = "btnUyeListeleme";
            this.btnUyeListeleme.Size = new System.Drawing.Size(190, 23);
            this.btnUyeListeleme.TabIndex = 2;
            this.btnUyeListeleme.Text = "Üye Listeleme";
            this.btnUyeListeleme.UseVisualStyleBackColor = true;
            this.btnUyeListeleme.Click += new System.EventHandler(this.btnUyeListeleme_Click);
            // 
            // btnYetkiTanimlama
            // 
            this.btnYetkiTanimlama.Location = new System.Drawing.Point(272, 231);
            this.btnYetkiTanimlama.Name = "btnYetkiTanimlama";
            this.btnYetkiTanimlama.Size = new System.Drawing.Size(190, 23);
            this.btnYetkiTanimlama.TabIndex = 2;
            this.btnYetkiTanimlama.Text = "Yetki Tanımlama";
            this.btnYetkiTanimlama.UseVisualStyleBackColor = true;
            this.btnYetkiTanimlama.Click += new System.EventHandler(this.btnYetkiTanimlama_Click);
            // 
            // frmAdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYetkiTanimlama);
            this.Controls.Add(this.btnUyeListeleme);
            this.Controls.Add(this.btnIhaleIslemleri);
            this.Controls.Add(this.btnAraclslemleri);
            this.Controls.Add(this.btnKullaniciIslemleri);
            this.Name = "frmAdminAnasayfa";
            this.Text = "AdminAnasayfa";
            this.Load += new System.EventHandler(this.frmAdminAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciIslemleri;
        private System.Windows.Forms.Button btnAraclslemleri;
        private System.Windows.Forms.Button btnIhaleIslemleri;
        private System.Windows.Forms.Button btnUyeListeleme;
        private System.Windows.Forms.Button btnYetkiTanimlama;
    }
}