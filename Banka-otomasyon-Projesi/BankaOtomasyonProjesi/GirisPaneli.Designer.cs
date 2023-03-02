namespace BankaOtomasyonProjesi
{
    partial class GirisPaneli
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.MaskedTextBox();
            this.txtUserPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnPanelGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(195, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(125, 27);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.ValidatingType = typeof(int);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(195, 142);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(125, 27);
            this.txtUserPassword.TabIndex = 3;
            this.txtUserPassword.ValidatingType = typeof(int);
            // 
            // btnPanelGiris
            // 
            this.btnPanelGiris.Location = new System.Drawing.Point(226, 199);
            this.btnPanelGiris.Name = "btnPanelGiris";
            this.btnPanelGiris.Size = new System.Drawing.Size(94, 29);
            this.btnPanelGiris.TabIndex = 4;
            this.btnPanelGiris.Text = "Giriş";
            this.btnPanelGiris.UseVisualStyleBackColor = true;
            this.btnPanelGiris.Click += new System.EventHandler(this.btnPanelGiris_Click);
            // 
            // GirisPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 299);
            this.Controls.Add(this.btnPanelGiris);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisPaneli";
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.GirisPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox txtUserName;
        private MaskedTextBox txtUserPassword;
        private Button btnPanelGiris;
    }
}