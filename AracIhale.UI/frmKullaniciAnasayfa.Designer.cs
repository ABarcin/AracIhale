
namespace AracIhale.UI
{
    partial class frmKullaniciAnasayfa
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
            this.btnIhaleListele = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIhaleListele
            // 
            this.btnIhaleListele.Location = new System.Drawing.Point(262, 162);
            this.btnIhaleListele.Name = "btnIhaleListele";
            this.btnIhaleListele.Size = new System.Drawing.Size(212, 23);
            this.btnIhaleListele.TabIndex = 0;
            this.btnIhaleListele.Text = "Ihale Listeleme";
            this.btnIhaleListele.UseVisualStyleBackColor = true;
            this.btnIhaleListele.Click += new System.EventHandler(this.btnIhaleListele_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.Location = new System.Drawing.Point(262, 191);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(212, 23);
            this.btnAracListele.TabIndex = 0;
            this.btnAracListele.Text = "Arac Listeleme";
            this.btnAracListele.UseVisualStyleBackColor = true;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // frmKullaniciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnIhaleListele);
            this.Name = "frmKullaniciAnasayfa";
            this.Text = "frmKullaniciAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIhaleListele;
        private System.Windows.Forms.Button btnAracListele;
    }
}