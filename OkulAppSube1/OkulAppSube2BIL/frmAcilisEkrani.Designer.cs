namespace OkulAppSube2BIL
{
    partial class frmAcilisEkrani
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAcilis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Öğrenci Kayıt Uygulaması";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Öğretmen Kayıt Uygulaması";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAcilis
            // 
            this.lblAcilis.AutoSize = true;
            this.lblAcilis.Location = new System.Drawing.Point(40, 12);
            this.lblAcilis.Name = "lblAcilis";
            this.lblAcilis.Size = new System.Drawing.Size(218, 52);
            this.lblAcilis.TabIndex = 4;
            this.lblAcilis.Text = "                       Hoş Geldiniz! \r\nLütfen Kayıt Yapacağınız Uygulamayı Seçini" +
    "z\r\n\r\n\r\n";
            // 
            // frmAcilisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 119);
            this.Controls.Add(this.lblAcilis);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "frmAcilisEkrani";
            this.Text = "Okul Kayıt Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAcilis;
    }
}