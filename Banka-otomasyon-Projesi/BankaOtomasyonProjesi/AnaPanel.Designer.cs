namespace BankaOtomasyonProjesi
{
    partial class FormOtomasyon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraCekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMusteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriGuncelleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniHesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapGuncelleSilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HesapRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıŞifreDeğiştirmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.islemlerToolStripMenuItem,
            this.musteriToolStripMenuItem,
            this.hesapToolStripMenuItem1,
            this.raporlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1109, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraCekmeToolStripMenuItem,
            this.paraYatırmaToolStripMenuItem,
            this.havaleToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.islemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // paraCekmeToolStripMenuItem
            // 
            this.paraCekmeToolStripMenuItem.Name = "paraCekmeToolStripMenuItem";
            this.paraCekmeToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.paraCekmeToolStripMenuItem.Text = "Para Çekme İşlemleri";
            this.paraCekmeToolStripMenuItem.Click += new System.EventHandler(this.paraCekmeToolStripMenuItem_Click);
            // 
            // paraYatırmaToolStripMenuItem
            // 
            this.paraYatırmaToolStripMenuItem.Name = "paraYatırmaToolStripMenuItem";
            this.paraYatırmaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.paraYatırmaToolStripMenuItem.Text = "Para Yatırma İşlemleri";
            this.paraYatırmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatırmaToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.havaleToolStripMenuItem.Text = "Havale İşlemleri";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMusteriToolStripMenuItem,
            this.musteriGuncelleSilToolStripMenuItem});
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.musteriToolStripMenuItem.Text = "Müşteri";
            // 
            // yeniMusteriToolStripMenuItem
            // 
            this.yeniMusteriToolStripMenuItem.Name = "yeniMusteriToolStripMenuItem";
            this.yeniMusteriToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.yeniMusteriToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniMusteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMusteriToolStripMenuItem_Click);
            // 
            // musteriGuncelleSilToolStripMenuItem
            // 
            this.musteriGuncelleSilToolStripMenuItem.Name = "musteriGuncelleSilToolStripMenuItem";
            this.musteriGuncelleSilToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.musteriGuncelleSilToolStripMenuItem.Text = "Güncelle/Sil";
            this.musteriGuncelleSilToolStripMenuItem.Click += new System.EventHandler(this.musteriGuncelleSilToolStripMenuItem_Click);
            // 
            // hesapToolStripMenuItem1
            // 
            this.hesapToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniHesapToolStripMenuItem,
            this.hesapGuncelleSilToolStripMenuItem1});
            this.hesapToolStripMenuItem1.Name = "hesapToolStripMenuItem1";
            this.hesapToolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.hesapToolStripMenuItem1.Text = "Hesap";
            // 
            // yeniHesapToolStripMenuItem
            // 
            this.yeniHesapToolStripMenuItem.Name = "yeniHesapToolStripMenuItem";
            this.yeniHesapToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.yeniHesapToolStripMenuItem.Text = "Yeni Hesap";
            this.yeniHesapToolStripMenuItem.Click += new System.EventHandler(this.yeniHesapToolStripMenuItem_Click);
            // 
            // hesapGuncelleSilToolStripMenuItem1
            // 
            this.hesapGuncelleSilToolStripMenuItem1.Name = "hesapGuncelleSilToolStripMenuItem1";
            this.hesapGuncelleSilToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.hesapGuncelleSilToolStripMenuItem1.Text = "Güncelle/Sil";
            this.hesapGuncelleSilToolStripMenuItem1.Click += new System.EventHandler(this.hesapGuncelleSilToolStripMenuItem1_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HesapRaporToolStripMenuItem,
            this.bankaRaporToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // HesapRaporToolStripMenuItem
            // 
            this.HesapRaporToolStripMenuItem.Name = "HesapRaporToolStripMenuItem";
            this.HesapRaporToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HesapRaporToolStripMenuItem.Text = "Hesap Rapor";
            this.HesapRaporToolStripMenuItem.Click += new System.EventHandler(this.HesapRaporToolStripMenuItem_Click);
            // 
            // bankaRaporToolStripMenuItem
            // 
            this.bankaRaporToolStripMenuItem.Name = "bankaRaporToolStripMenuItem";
            this.bankaRaporToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bankaRaporToolStripMenuItem.Text = "Banka Rapor";
            this.bankaRaporToolStripMenuItem.Click += new System.EventHandler(this.bankaRaporToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıŞifreDeğiştirmeToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // kullanıcıŞifreDeğiştirmeToolStripMenuItem
            // 
            this.kullanıcıŞifreDeğiştirmeToolStripMenuItem.Name = "kullanıcıŞifreDeğiştirmeToolStripMenuItem";
            this.kullanıcıŞifreDeğiştirmeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.kullanıcıŞifreDeğiştirmeToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıŞifreDeğiştirmeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıŞifreDeğiştirmeToolStripMenuItem_Click);
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.CikisToolStripMenuItem.Text = "Çıkış";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.CikisToolStripMenuItem_Click);
            // 
            // FormOtomasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 829);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOtomasyon";
            this.Text = "Banka Otomasyonu";
            this.Load += new System.EventHandler(this.FormOtomasyon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem islemlerToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem HesapRaporToolStripMenuItem;
        private ToolStripMenuItem bankaRaporToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem paraCekmeToolStripMenuItem;
        private ToolStripMenuItem paraYatırmaToolStripMenuItem;
        private ToolStripMenuItem havaleToolStripMenuItem;
        private ToolStripMenuItem hesapToolStripMenuItem1;
        private ToolStripMenuItem yeniHesapToolStripMenuItem;
        private ToolStripMenuItem hesapGuncelleSilToolStripMenuItem1;
        private ToolStripMenuItem musteriToolStripMenuItem;
        private ToolStripMenuItem yeniMusteriToolStripMenuItem;
        private ToolStripMenuItem musteriGuncelleSilToolStripMenuItem;
        private ToolStripMenuItem kullanıcıŞifreDeğiştirmeToolStripMenuItem;
        private ToolStripMenuItem CikisToolStripMenuItem;
    }
}