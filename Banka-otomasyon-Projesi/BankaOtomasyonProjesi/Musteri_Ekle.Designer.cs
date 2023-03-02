namespace BankaOtomasyonProjesi
{
    partial class Musteri_Ekle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMusteriEkleEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriEkleMusteriNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriEkleMail = new System.Windows.Forms.TextBox();
            this.txtMusteriEkleTip = new System.Windows.Forms.ComboBox();
            this.txtMusteriEkleAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMusteriEkleSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriEkleAd = new System.Windows.Forms.TextBox();
            this.txtMusteriEkleTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtMusteriEkleKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(639, 203);
            this.dataGridView1.TabIndex = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMusteriEkleEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMusteriEkleMusteriNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMusteriEkleMail);
            this.groupBox1.Controls.Add(this.txtMusteriEkleTip);
            this.groupBox1.Controls.Add(this.txtMusteriEkleAdres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMusteriEkleSoyad);
            this.groupBox1.Controls.Add(this.txtMusteriEkleAd);
            this.groupBox1.Controls.Add(this.txtMusteriEkleTelefon);
            this.groupBox1.Controls.Add(this.txtMusteriEkleKimlikNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(19, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 290);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgi";
            // 
            // btnMusteriEkleEkle
            // 
            this.btnMusteriEkleEkle.Location = new System.Drawing.Point(513, 244);
            this.btnMusteriEkleEkle.Name = "btnMusteriEkleEkle";
            this.btnMusteriEkleEkle.Size = new System.Drawing.Size(94, 29);
            this.btnMusteriEkleEkle.TabIndex = 70;
            this.btnMusteriEkleEkle.Text = "Ekle";
            this.btnMusteriEkleEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkleEkle.Click += new System.EventHandler(this.btnMusteriEkleEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Müşteri No";
            // 
            // txtMusteriEkleMusteriNo
            // 
            this.txtMusteriEkleMusteriNo.Location = new System.Drawing.Point(124, 49);
            this.txtMusteriEkleMusteriNo.Mask = "000000000";
            this.txtMusteriEkleMusteriNo.Name = "txtMusteriEkleMusteriNo";
            this.txtMusteriEkleMusteriNo.ReadOnly = true;
            this.txtMusteriEkleMusteriNo.Size = new System.Drawing.Size(134, 27);
            this.txtMusteriEkleMusteriNo.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Müşteri Tipi";
            // 
            // txtMusteriEkleMail
            // 
            this.txtMusteriEkleMail.Location = new System.Drawing.Point(388, 52);
            this.txtMusteriEkleMail.Name = "txtMusteriEkleMail";
            this.txtMusteriEkleMail.Size = new System.Drawing.Size(132, 27);
            this.txtMusteriEkleMail.TabIndex = 79;
            // 
            // txtMusteriEkleTip
            // 
            this.txtMusteriEkleTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMusteriEkleTip.FormattingEnabled = true;
            this.txtMusteriEkleTip.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.txtMusteriEkleTip.Location = new System.Drawing.Point(388, 85);
            this.txtMusteriEkleTip.Name = "txtMusteriEkleTip";
            this.txtMusteriEkleTip.Size = new System.Drawing.Size(134, 28);
            this.txtMusteriEkleTip.TabIndex = 75;
            // 
            // txtMusteriEkleAdres
            // 
            this.txtMusteriEkleAdres.Location = new System.Drawing.Point(388, 119);
            this.txtMusteriEkleAdres.Multiline = true;
            this.txtMusteriEkleAdres.Name = "txtMusteriEkleAdres";
            this.txtMusteriEkleAdres.Size = new System.Drawing.Size(219, 104);
            this.txtMusteriEkleAdres.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "Mail Adresi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Telefon No";
            // 
            // txtMusteriEkleSoyad
            // 
            this.txtMusteriEkleSoyad.Location = new System.Drawing.Point(124, 154);
            this.txtMusteriEkleSoyad.Name = "txtMusteriEkleSoyad";
            this.txtMusteriEkleSoyad.Size = new System.Drawing.Size(134, 27);
            this.txtMusteriEkleSoyad.TabIndex = 81;
            // 
            // txtMusteriEkleAd
            // 
            this.txtMusteriEkleAd.Location = new System.Drawing.Point(124, 121);
            this.txtMusteriEkleAd.Name = "txtMusteriEkleAd";
            this.txtMusteriEkleAd.Size = new System.Drawing.Size(134, 27);
            this.txtMusteriEkleAd.TabIndex = 80;
            // 
            // txtMusteriEkleTelefon
            // 
            this.txtMusteriEkleTelefon.Location = new System.Drawing.Point(124, 192);
            this.txtMusteriEkleTelefon.Mask = "(999) 000-0000";
            this.txtMusteriEkleTelefon.Name = "txtMusteriEkleTelefon";
            this.txtMusteriEkleTelefon.Size = new System.Drawing.Size(134, 27);
            this.txtMusteriEkleTelefon.TabIndex = 74;
            // 
            // txtMusteriEkleKimlikNo
            // 
            this.txtMusteriEkleKimlikNo.Location = new System.Drawing.Point(124, 86);
            this.txtMusteriEkleKimlikNo.Mask = "00000000000";
            this.txtMusteriEkleKimlikNo.Name = "txtMusteriEkleKimlikNo";
            this.txtMusteriEkleKimlikNo.Size = new System.Drawing.Size(134, 27);
            this.txtMusteriEkleKimlikNo.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Ad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 68;
            this.label8.Text = "TC Kimlik No";
            // 
            // Musteri_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Musteri_Ekle";
            this.Text = "Müşteri Ekle";
            this.Load += new System.EventHandler(this.MüsteriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnMusteriEkleEkle;
        private Label label1;
        private MaskedTextBox txtMusteriEkleMusteriNo;
        private Label label5;
        private TextBox txtMusteriEkleMail;
        private ComboBox txtMusteriEkleTip;
        private TextBox txtMusteriEkleAdres;
        private Label label6;
        private Label label7;
        private TextBox txtMusteriEkleSoyad;
        private TextBox txtMusteriEkleAd;
        private MaskedTextBox txtMusteriEkleTelefon;
        private MaskedTextBox txtMusteriEkleKimlikNo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
    }
}