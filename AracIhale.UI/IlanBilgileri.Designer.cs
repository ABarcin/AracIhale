
namespace AracIhale.UI
{
    partial class IlanBilgileri
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
            this.grpIlanBilgileri = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtIlanAciklama = new System.Windows.Forms.TextBox();
            this.txtIlanBaslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpIlanBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIlanBilgileri
            // 
            this.grpIlanBilgileri.Controls.Add(this.btnKaydet);
            this.grpIlanBilgileri.Controls.Add(this.txtIlanAciklama);
            this.grpIlanBilgileri.Controls.Add(this.txtIlanBaslik);
            this.grpIlanBilgileri.Controls.Add(this.label2);
            this.grpIlanBilgileri.Controls.Add(this.label1);
            this.grpIlanBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpIlanBilgileri.Name = "grpIlanBilgileri";
            this.grpIlanBilgileri.Size = new System.Drawing.Size(480, 349);
            this.grpIlanBilgileri.TabIndex = 0;
            this.grpIlanBilgileri.TabStop = false;
            this.grpIlanBilgileri.Text = "İlan Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(394, 320);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // txtIlanAciklama
            // 
            this.txtIlanAciklama.Location = new System.Drawing.Point(92, 71);
            this.txtIlanAciklama.Multiline = true;
            this.txtIlanAciklama.Name = "txtIlanAciklama";
            this.txtIlanAciklama.Size = new System.Drawing.Size(377, 243);
            this.txtIlanAciklama.TabIndex = 2;
            // 
            // txtIlanBaslik
            // 
            this.txtIlanBaslik.Location = new System.Drawing.Point(92, 36);
            this.txtIlanBaslik.Name = "txtIlanBaslik";
            this.txtIlanBaslik.Size = new System.Drawing.Size(377, 20);
            this.txtIlanBaslik.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İlan Açıklaması:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan Başlığı:";
            // 
            // IlanBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 373);
            this.Controls.Add(this.grpIlanBilgileri);
            this.Name = "IlanBilgileri";
            this.Text = "IlanBilgileri";
            this.grpIlanBilgileri.ResumeLayout(false);
            this.grpIlanBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIlanBilgileri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtIlanAciklama;
        private System.Windows.Forms.TextBox txtIlanBaslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}