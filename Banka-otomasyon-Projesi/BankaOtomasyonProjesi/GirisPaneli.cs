using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonProjesi
{
    public partial class GirisPaneli : Form
    {
        public Bank bank { get; set; }

        public GirisPaneli()
        {
            InitializeComponent();
            bank = new("A bank");
            

            User admin = new User(bank);
            admin.UserName = "admin";
            admin.UserPassword = "admin123";
            admin.TCKimlikNo = 12345678901;
            admin.Ad = "Ahmet";
            admin.Soyad = "Yılmaz";
            admin.Adres = "Ankara, Türkiye";
            admin.Telefon = "555-555-1212";
            admin.MailAdresi = "ahmet.yilmaz@example.com";

            User user1 = new User(bank);
            user1.UserName = "mehmet";
            user1.UserPassword = "mehmet123";
            user1.TCKimlikNo = 12345678902;
            user1.Ad = "Mehmet";
            user1.Soyad = "Çelik";
            user1.Adres = "Istanbul, Türkiye";
            user1.Telefon = "555-555-1213";
            user1.MailAdresi = "mehmet.celik@example.com";

            User user2 = new User(bank);
            user2.UserName = "Ayşe456";
            user2.UserPassword = "herpassword456";
            user2.TCKimlikNo = 12345678903;
            user2.Ad = "Ayşe";
            user2.Soyad = "Öztürk";
            user2.Adres = "Bursa, Türkiye";
            user2.Telefon = "555-555-1214";
            user2.MailAdresi = "ayse.ozturk@example.com";

            User user3 = new User(bank);
            user3.UserName = "Ali789";
            user3.UserPassword = "hispassword789";
            user3.TCKimlikNo = 12345678904;
            user3.Ad = "Ali";
            user3.Soyad = "Kara";
            user3.Adres = "Antalya, Türkiye";
            user3.Telefon = "555-555-1215";
            user3.MailAdresi = "ali.kara@example.com";

            User user4 = new User(bank);
            user4.UserName = "Fatma123";
            user4.UserPassword = "herpassword123";
            user4.TCKimlikNo = 12345678905;
            user4.Ad = "Fatma";
            user4.Soyad = "Gül";
            user4.Adres = "Izmir, Türkiye";
            user4.Telefon = "555-555-1216";
            user4.MailAdresi = "fatma.gul@example.com";

        }

        private void btnPanelGiris_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword =txtUserPassword.Text;

            // Kullanıcı kontrolü
            if (bank.CheckUser(userName, userPassword))
            {

                FormOtomasyon ana_Panel = new(bank);
                ana_Panel.bank = this.bank;
                ana_Panel.Show();
            }
            else MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            
        }

        private void GirisPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
