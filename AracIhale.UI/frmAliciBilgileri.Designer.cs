
namespace AracIhale.UI
{
    partial class frmAliciBilgileri
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
            this.grpAliciBilgileri = new System.Windows.Forms.GroupBox();
            this.lstAliciBilgileri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAliciBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAliciBilgileri
            // 
            this.grpAliciBilgileri.Controls.Add(this.lstAliciBilgileri);
            this.grpAliciBilgileri.Location = new System.Drawing.Point(12, 12);
            this.grpAliciBilgileri.Name = "grpAliciBilgileri";
            this.grpAliciBilgileri.Size = new System.Drawing.Size(623, 130);
            this.grpAliciBilgileri.TabIndex = 0;
            this.grpAliciBilgileri.TabStop = false;
            this.grpAliciBilgileri.Text = "Alıcı Bilgileri";
            // 
            // lstAliciBilgileri
            // 
            this.lstAliciBilgileri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstAliciBilgileri.GridLines = true;
            this.lstAliciBilgileri.HideSelection = false;
            this.lstAliciBilgileri.Location = new System.Drawing.Point(6, 19);
            this.lstAliciBilgileri.Name = "lstAliciBilgileri";
            this.lstAliciBilgileri.Size = new System.Drawing.Size(611, 97);
            this.lstAliciBilgileri.TabIndex = 0;
            this.lstAliciBilgileri.UseCompatibleStateImageBehavior = false;
            this.lstAliciBilgileri.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Soyadı";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kullanıcı Adı";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bireysel/Kurumsal";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cep Telefonu";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail Adresi";
            this.columnHeader6.Width = 100;
            // 
            // AliciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 147);
            this.Controls.Add(this.grpAliciBilgileri);
            this.Name = "AliciBilgileri";
            this.Text = "Alıcı Bilgileri";
            this.grpAliciBilgileri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAliciBilgileri;
        private System.Windows.Forms.ListView lstAliciBilgileri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}