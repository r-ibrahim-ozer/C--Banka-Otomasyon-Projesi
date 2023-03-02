namespace BankaOtomasyonProjesi
{
    partial class Para_Yatir
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
            this.txtParaYatirSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnParaYatirHesapNoAra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParaYatirHesapNoNV = new System.Windows.Forms.TextBox();
            this.txtParaYatirHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtParaYatirMusteriNo = new System.Windows.Forms.MaskedTextBox();
            this.btnParaYatirMusteriNoAra = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtParaYatirBakiye = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParaYatirAd = new System.Windows.Forms.TextBox();
            this.txtParaYatirKimlikNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtParaYatirTutar = new System.Windows.Forms.MaskedTextBox();
            this.btnParaYatirYatir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap NO";
            // 
            // txtParaYatirSoyad
            // 
            this.txtParaYatirSoyad.Location = new System.Drawing.Point(143, 119);
            this.txtParaYatirSoyad.Name = "txtParaYatirSoyad";
            this.txtParaYatirSoyad.ReadOnly = true;
            this.txtParaYatirSoyad.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirSoyad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bakiye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yatırılacak Tutar";
            // 
            // btnParaYatirHesapNoAra
            // 
            this.btnParaYatirHesapNoAra.Location = new System.Drawing.Point(235, 39);
            this.btnParaYatirHesapNoAra.Name = "btnParaYatirHesapNoAra";
            this.btnParaYatirHesapNoAra.Size = new System.Drawing.Size(94, 29);
            this.btnParaYatirHesapNoAra.TabIndex = 10;
            this.btnParaYatirHesapNoAra.Text = "Ara";
            this.btnParaYatirHesapNoAra.UseVisualStyleBackColor = true;
            this.btnParaYatirHesapNoAra.Click += new System.EventHandler(this.btnParaYatirHesapNoAra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParaYatirHesapNoNV);
            this.groupBox1.Controls.Add(this.txtParaYatirHesapNo);
            this.groupBox1.Controls.Add(this.txtParaYatirMusteriNo);
            this.groupBox1.Controls.Add(this.btnParaYatirMusteriNoAra);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnParaYatirHesapNoAra);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 195);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            // 
            // txtParaYatirHesapNoNV
            // 
            this.txtParaYatirHesapNoNV.Location = new System.Drawing.Point(89, 151);
            this.txtParaYatirHesapNoNV.Name = "txtParaYatirHesapNoNV";
            this.txtParaYatirHesapNoNV.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirHesapNoNV.TabIndex = 19;
            this.txtParaYatirHesapNoNV.Visible = false;
            // 
            // txtParaYatirHesapNo
            // 
            this.txtParaYatirHesapNo.Location = new System.Drawing.Point(89, 40);
            this.txtParaYatirHesapNo.Mask = "00000000";
            this.txtParaYatirHesapNo.Name = "txtParaYatirHesapNo";
            this.txtParaYatirHesapNo.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirHesapNo.TabIndex = 18;
            // 
            // txtParaYatirMusteriNo
            // 
            this.txtParaYatirMusteriNo.Location = new System.Drawing.Point(90, 104);
            this.txtParaYatirMusteriNo.Mask = "00000";
            this.txtParaYatirMusteriNo.Name = "txtParaYatirMusteriNo";
            this.txtParaYatirMusteriNo.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirMusteriNo.TabIndex = 17;
            // 
            // btnParaYatirMusteriNoAra
            // 
            this.btnParaYatirMusteriNoAra.Location = new System.Drawing.Point(235, 101);
            this.btnParaYatirMusteriNoAra.Name = "btnParaYatirMusteriNoAra";
            this.btnParaYatirMusteriNoAra.Size = new System.Drawing.Size(94, 29);
            this.btnParaYatirMusteriNoAra.TabIndex = 16;
            this.btnParaYatirMusteriNoAra.Text = "Ara";
            this.btnParaYatirMusteriNoAra.UseVisualStyleBackColor = true;
            this.btnParaYatirMusteriNoAra.Click += new System.EventHandler(this.btnParaYatirMusteriNoAra_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Müşteri NO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParaYatirBakiye);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtParaYatirAd);
            this.groupBox2.Controls.Add(this.txtParaYatirKimlikNo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtParaYatirSoyad);
            this.groupBox2.Location = new System.Drawing.Point(422, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 195);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hesap Bilgileri";
            // 
            // txtParaYatirBakiye
            // 
            this.txtParaYatirBakiye.Location = new System.Drawing.Point(143, 158);
            this.txtParaYatirBakiye.Name = "txtParaYatirBakiye";
            this.txtParaYatirBakiye.ReadOnly = true;
            this.txtParaYatirBakiye.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirBakiye.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adı";
            // 
            // txtParaYatirAd
            // 
            this.txtParaYatirAd.Location = new System.Drawing.Point(143, 83);
            this.txtParaYatirAd.Name = "txtParaYatirAd";
            this.txtParaYatirAd.ReadOnly = true;
            this.txtParaYatirAd.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirAd.TabIndex = 10;
            // 
            // txtParaYatirKimlikNo
            // 
            this.txtParaYatirKimlikNo.Location = new System.Drawing.Point(143, 45);
            this.txtParaYatirKimlikNo.Name = "txtParaYatirKimlikNo";
            this.txtParaYatirKimlikNo.ReadOnly = true;
            this.txtParaYatirKimlikNo.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirKimlikNo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "TCKimlik NO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtParaYatirTutar);
            this.groupBox3.Controls.Add(this.btnParaYatirYatir);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(18, 233);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 106);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Para Yatır";
            // 
            // txtParaYatirTutar
            // 
            this.txtParaYatirTutar.Location = new System.Drawing.Point(138, 42);
            this.txtParaYatirTutar.Mask = "0000000000";
            this.txtParaYatirTutar.Name = "txtParaYatirTutar";
            this.txtParaYatirTutar.Size = new System.Drawing.Size(125, 27);
            this.txtParaYatirTutar.TabIndex = 13;
            this.txtParaYatirTutar.Text = "0";
            // 
            // btnParaYatirYatir
            // 
            this.btnParaYatirYatir.Location = new System.Drawing.Point(404, 42);
            this.btnParaYatirYatir.Name = "btnParaYatirYatir";
            this.btnParaYatirYatir.Size = new System.Drawing.Size(94, 29);
            this.btnParaYatirYatir.TabIndex = 11;
            this.btnParaYatirYatir.Text = "Yatır";
            this.btnParaYatirYatir.UseVisualStyleBackColor = true;
            this.btnParaYatirYatir.Click += new System.EventHandler(this.btnParaYatirYatir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(976, 193);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // Para_Yatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Para_Yatir";
            this.Text = "Para Yatır";
            this.Load += new System.EventHandler(this.Para_Yatir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtParaYatirSoyad;
        private Label label3;
        private Label label4;
        private Button btnParaYatirHesapNoAra;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox txtParaYatirAd;
        private TextBox txtParaYatirKimlikNo;
        private Label label2;
        private Button btnParaYatirYatir;
        private Button btnParaYatirMusteriNoAra;
        private Label label7;
        private TextBox txtParaYatirBakiye;
        private Label label6;
        private DataGridView dataGridView1;
        private MaskedTextBox txtParaYatirHesapNo;
        private MaskedTextBox txtParaYatirMusteriNo;
        private MaskedTextBox txtParaYatirTutar;
        private TextBox txtParaYatirHesapNoNV;
    }
}