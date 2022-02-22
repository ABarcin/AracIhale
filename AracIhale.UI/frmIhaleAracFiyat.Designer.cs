
namespace AracIhale.UI
{
    partial class frmIhaleAracFiyat
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
            this.gbIhaleFiyat = new System.Windows.Forms.GroupBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtIhaleBitisFiyat = new System.Windows.Forms.TextBox();
            this.lblIhaleBitisFiyat = new System.Windows.Forms.Label();
            this.txtIhaleBaslangicFiyat = new System.Windows.Forms.TextBox();
            this.lblIhaleBaslangicFiyat = new System.Windows.Forms.Label();
            this.lblAracId = new System.Windows.Forms.Label();
            this.errorProviderIhaleAracFiyat = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbIhaleFiyat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIhaleAracFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // gbIhaleFiyat
            // 
            this.gbIhaleFiyat.Controls.Add(this.cmbArac);
            this.gbIhaleFiyat.Controls.Add(this.btnKaydet);
            this.gbIhaleFiyat.Controls.Add(this.txtIhaleBitisFiyat);
            this.gbIhaleFiyat.Controls.Add(this.lblIhaleBitisFiyat);
            this.gbIhaleFiyat.Controls.Add(this.txtIhaleBaslangicFiyat);
            this.gbIhaleFiyat.Controls.Add(this.lblIhaleBaslangicFiyat);
            this.gbIhaleFiyat.Controls.Add(this.lblAracId);
            this.gbIhaleFiyat.Location = new System.Drawing.Point(15, 14);
            this.gbIhaleFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIhaleFiyat.Name = "gbIhaleFiyat";
            this.gbIhaleFiyat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbIhaleFiyat.Size = new System.Drawing.Size(373, 319);
            this.gbIhaleFiyat.TabIndex = 1;
            this.gbIhaleFiyat.TabStop = false;
            this.gbIhaleFiyat.Text = "İhale Fiyat";
            // 
            // cmbArac
            // 
            this.cmbArac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(175, 48);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(165, 24);
            this.cmbArac.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(245, 242);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 38);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtIhaleBitisFiyat
            // 
            this.txtIhaleBitisFiyat.Location = new System.Drawing.Point(175, 145);
            this.txtIhaleBitisFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIhaleBitisFiyat.Name = "txtIhaleBitisFiyat";
            this.txtIhaleBitisFiyat.Size = new System.Drawing.Size(165, 22);
            this.txtIhaleBitisFiyat.TabIndex = 8;
            // 
            // lblIhaleBitisFiyat
            // 
            this.lblIhaleBitisFiyat.AutoSize = true;
            this.lblIhaleBitisFiyat.Location = new System.Drawing.Point(11, 148);
            this.lblIhaleBitisFiyat.Name = "lblIhaleBitisFiyat";
            this.lblIhaleBitisFiyat.Size = new System.Drawing.Size(109, 17);
            this.lblIhaleBitisFiyat.TabIndex = 7;
            this.lblIhaleBitisFiyat.Text = "İhale Bitiş Fiyatı:";
            // 
            // txtIhaleBaslangicFiyat
            // 
            this.txtIhaleBaslangicFiyat.Location = new System.Drawing.Point(175, 95);
            this.txtIhaleBaslangicFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIhaleBaslangicFiyat.Name = "txtIhaleBaslangicFiyat";
            this.txtIhaleBaslangicFiyat.Size = new System.Drawing.Size(165, 22);
            this.txtIhaleBaslangicFiyat.TabIndex = 8;
            // 
            // lblIhaleBaslangicFiyat
            // 
            this.lblIhaleBaslangicFiyat.AutoSize = true;
            this.lblIhaleBaslangicFiyat.Location = new System.Drawing.Point(11, 98);
            this.lblIhaleBaslangicFiyat.Name = "lblIhaleBaslangicFiyat";
            this.lblIhaleBaslangicFiyat.Size = new System.Drawing.Size(144, 17);
            this.lblIhaleBaslangicFiyat.TabIndex = 7;
            this.lblIhaleBaslangicFiyat.Text = "İhale Başlangıç Fiyatı:";
            // 
            // lblAracId
            // 
            this.lblAracId.AutoSize = true;
            this.lblAracId.Location = new System.Drawing.Point(11, 48);
            this.lblAracId.Name = "lblAracId";
            this.lblAracId.Size = new System.Drawing.Size(37, 17);
            this.lblAracId.TabIndex = 7;
            this.lblAracId.Text = "Arac";
            // 
            // errorProviderIhaleAracFiyat
            // 
            this.errorProviderIhaleAracFiyat.ContainerControl = this;
            // 
            // frmIhaleAracFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 358);
            this.Controls.Add(this.gbIhaleFiyat);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIhaleAracFiyat";
            this.Text = "IhaleAracFiyat";
            this.Load += new System.EventHandler(this.IhaleAracFiyat_Load);
            this.gbIhaleFiyat.ResumeLayout(false);
            this.gbIhaleFiyat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIhaleAracFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIhaleFiyat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtIhaleBitisFiyat;
        private System.Windows.Forms.Label lblIhaleBitisFiyat;
        private System.Windows.Forms.TextBox txtIhaleBaslangicFiyat;
        private System.Windows.Forms.Label lblIhaleBaslangicFiyat;
        private System.Windows.Forms.Label lblAracId;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.ErrorProvider errorProviderIhaleAracFiyat;
    }
}