
namespace AracIhale.UI
{
    partial class frmIletisim
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
            this.cmbIletisimTur = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIletisimBilgi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lsvIletisim = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIletisimTur
            // 
            this.cmbIletisimTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIletisimTur.FormattingEnabled = true;
            this.cmbIletisimTur.Location = new System.Drawing.Point(95, 215);
            this.cmbIletisimTur.Name = "cmbIletisimTur";
            this.cmbIletisimTur.Size = new System.Drawing.Size(194, 21);
            this.cmbIletisimTur.TabIndex = 0;
            this.cmbIletisimTur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İletişim Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İletişim Bilgi:";
            // 
            // txtIletisimBilgi
            // 
            this.txtIletisimBilgi.Location = new System.Drawing.Point(95, 249);
            this.txtIletisimBilgi.Name = "txtIletisimBilgi";
            this.txtIletisimBilgi.Size = new System.Drawing.Size(194, 20);
            this.txtIletisimBilgi.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnKaydet.Location = new System.Drawing.Point(214, 275);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lsvIletisim
            // 
            this.lsvIletisim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvIletisim.HideSelection = false;
            this.lsvIletisim.Location = new System.Drawing.Point(12, 12);
            this.lsvIletisim.Name = "lsvIletisim";
            this.lsvIletisim.Size = new System.Drawing.Size(437, 197);
            this.lsvIletisim.TabIndex = 5;
            this.lsvIletisim.UseCompatibleStateImageBehavior = false;
            this.lsvIletisim.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Iletisim Turu";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İletisim Bilgi";
            this.columnHeader2.Width = 295;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmIletisim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.lsvIletisim);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtIletisimBilgi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIletisimTur);
            this.Name = "frmIletisim";
            this.Text = "frmIletisim";
            this.Load += new System.EventHandler(this.frmIletisim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIletisimTur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIletisimBilgi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView lsvIletisim;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}