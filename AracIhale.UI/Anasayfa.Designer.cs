
namespace AracIhale.UI
{
    partial class Anasayfa
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKurumsal = new System.Windows.Forms.Button();
            this.btnBireysel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hızlı Arama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vitrin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Site Tanıtım Alanı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Banner";
            // 
            // btnKurumsal
            // 
            this.btnKurumsal.Location = new System.Drawing.Point(286, 202);
            this.btnKurumsal.Name = "btnKurumsal";
            this.btnKurumsal.Size = new System.Drawing.Size(137, 23);
            this.btnKurumsal.TabIndex = 10;
            this.btnKurumsal.Text = "Kurumsal Üye Kayıt Ol";
            this.btnKurumsal.UseVisualStyleBackColor = true;
            this.btnKurumsal.Click += new System.EventHandler(this.btnKurumsal_Click);
            // 
            // btnBireysel
            // 
            this.btnBireysel.Location = new System.Drawing.Point(286, 173);
            this.btnBireysel.Name = "btnBireysel";
            this.btnBireysel.Size = new System.Drawing.Size(137, 23);
            this.btnBireysel.TabIndex = 9;
            this.btnBireysel.Text = "Bireysel Üye Kayıt Ol";
            this.btnBireysel.UseVisualStyleBackColor = true;
            this.btnBireysel.Click += new System.EventHandler(this.btnBireysel_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKurumsal);
            this.Controls.Add(this.btnBireysel);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKurumsal;
        private System.Windows.Forms.Button btnBireysel;
    }
}