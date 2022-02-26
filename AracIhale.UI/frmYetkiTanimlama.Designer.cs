
namespace AracIhale.UI
{
    partial class frmYetkiTanimlama
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoller = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSayfalar = new System.Windows.Forms.ComboBox();
            this.flpYetkiler = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol Listesi";
            // 
            // cmbRoller
            // 
            this.cmbRoller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoller.FormattingEnabled = true;
            this.cmbRoller.Location = new System.Drawing.Point(31, 50);
            this.cmbRoller.Name = "cmbRoller";
            this.cmbRoller.Size = new System.Drawing.Size(222, 21);
            this.cmbRoller.TabIndex = 1;
            this.cmbRoller.SelectedIndexChanged += new System.EventHandler(this.cmbRoller_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sayfa Listesi";
            // 
            // cmbSayfalar
            // 
            this.cmbSayfalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSayfalar.FormattingEnabled = true;
            this.cmbSayfalar.Location = new System.Drawing.Point(31, 214);
            this.cmbSayfalar.Name = "cmbSayfalar";
            this.cmbSayfalar.Size = new System.Drawing.Size(222, 21);
            this.cmbSayfalar.TabIndex = 2;
            this.cmbSayfalar.SelectedIndexChanged += new System.EventHandler(this.cmbSayfalar_SelectedIndexChanged);
            // 
            // flpYetkiler
            // 
            this.flpYetkiler.Location = new System.Drawing.Point(321, 50);
            this.flpYetkiler.Name = "flpYetkiler";
            this.flpYetkiler.Size = new System.Drawing.Size(236, 309);
            this.flpYetkiler.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(321, 381);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(236, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmYetkiTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.flpYetkiler);
            this.Controls.Add(this.cmbSayfalar);
            this.Controls.Add(this.cmbRoller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmYetkiTanimlama";
            this.Text = "frmYetkiTanimlama";
            this.Load += new System.EventHandler(this.frmYetkiTanimlama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSayfalar;
        private System.Windows.Forms.FlowLayoutPanel flpYetkiler;
        private System.Windows.Forms.Button btnGuncelle;
    }
}