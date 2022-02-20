
namespace AracIhale.UI
{
    partial class frmTramerBilgileri
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
            this.gbTramer = new System.Windows.Forms.GroupBox();
            this.flpTramerDurum = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRuntime = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.epMoney = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbTramer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTramer
            // 
            this.gbTramer.Controls.Add(this.flpTramerDurum);
            this.gbTramer.Controls.Add(this.flpRuntime);
            this.gbTramer.Controls.Add(this.txtMoney);
            this.gbTramer.Controls.Add(this.label1);
            this.gbTramer.Location = new System.Drawing.Point(13, 13);
            this.gbTramer.Name = "gbTramer";
            this.gbTramer.Size = new System.Drawing.Size(432, 599);
            this.gbTramer.TabIndex = 0;
            this.gbTramer.TabStop = false;
            this.gbTramer.Text = "Tramer Bilgileri";
            // 
            // flpTramerDurum
            // 
            this.flpTramerDurum.Location = new System.Drawing.Point(104, 78);
            this.flpTramerDurum.Name = "flpTramerDurum";
            this.flpTramerDurum.Size = new System.Drawing.Size(320, 25);
            this.flpTramerDurum.TabIndex = 4;
            // 
            // flpRuntime
            // 
            this.flpRuntime.Location = new System.Drawing.Point(6, 109);
            this.flpRuntime.Name = "flpRuntime";
            this.flpRuntime.Size = new System.Drawing.Size(418, 484);
            this.flpRuntime.TabIndex = 3;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(160, 39);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(220, 20);
            this.txtMoney.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Tramer Tutarı (TL) :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(291, 620);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(154, 23);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // epMoney
            // 
            this.epMoney.ContainerControl = this;
            // 
            // frmTramerBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 655);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.gbTramer);
            this.Name = "frmTramerBilgileri";
            this.Text = "frmTramerBilgileri";
            this.Load += new System.EventHandler(this.frmTramerBilgileri_Load);
            this.gbTramer.ResumeLayout(false);
            this.gbTramer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTramer;
        private System.Windows.Forms.FlowLayoutPanel flpRuntime;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpTramerDurum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ErrorProvider epMoney;
    }
}