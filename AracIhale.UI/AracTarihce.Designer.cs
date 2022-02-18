
namespace AracIhale.UI
{
    partial class AracTarihce
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
            this.grpAracTarihce = new System.Windows.Forms.GroupBox();
            this.lstAracTarihce = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpAracTarihce.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAracTarihce
            // 
            this.grpAracTarihce.Controls.Add(this.lstAracTarihce);
            this.grpAracTarihce.Location = new System.Drawing.Point(12, 12);
            this.grpAracTarihce.Name = "grpAracTarihce";
            this.grpAracTarihce.Size = new System.Drawing.Size(365, 422);
            this.grpAracTarihce.TabIndex = 0;
            this.grpAracTarihce.TabStop = false;
            this.grpAracTarihce.Text = "Araç Tarihçe";
            // 
            // lstAracTarihce
            // 
            this.lstAracTarihce.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstAracTarihce.GridLines = true;
            this.lstAracTarihce.HideSelection = false;
            this.lstAracTarihce.Location = new System.Drawing.Point(6, 19);
            this.lstAracTarihce.Name = "lstAracTarihce";
            this.lstAracTarihce.Size = new System.Drawing.Size(353, 392);
            this.lstAracTarihce.TabIndex = 0;
            this.lstAracTarihce.UseCompatibleStateImageBehavior = false;
            this.lstAracTarihce.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Araç Statüsü";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tarih";
            this.columnHeader3.Width = 150;
            // 
            // AracTarihce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 441);
            this.Controls.Add(this.grpAracTarihce);
            this.Name = "AracTarihce";
            this.Text = "AracTarihce";
            this.grpAracTarihce.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAracTarihce;
        private System.Windows.Forms.ListView lstAracTarihce;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}