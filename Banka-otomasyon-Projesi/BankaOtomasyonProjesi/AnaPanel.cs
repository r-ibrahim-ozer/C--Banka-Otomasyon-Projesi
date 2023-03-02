using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace BankaOtomasyonProjesi
{
    public partial class FormOtomasyon : Form
    {
        public Bank bank { get; set; }
        
        public FormOtomasyon(Bank bank)
        {
            WindowState = FormWindowState.Maximized;
            this.bank = bank;

            Costumer costumer1 = new()
            {
                TCKimlikNo = 12345678900,
                Ad = "Ahmet",
                Soyad = "Yýlmaz",
                Adres = "Ankara, Turkey",
                Telefon = "5551234567",
                MailAdresi = "ahmetyilmaz@example.com",
                MusteriTipi = Costumer.EMusteriTipi.Bireysel
            };

            Account account1 = new(bank, costumer1, 500)
            {
                Balance = 1000,
                costumer = costumer1
            };

            Costumer costumer2 = new()
            {
                TCKimlikNo = 23456789010,
                Ad = "Mehmet",
                Soyad = "Öztürk",
                Adres = "Ýstanbul, Turkey",
                Telefon = "5552345678",
                MailAdresi = "mehmetozturk@example.com",
                MusteriTipi = Costumer.EMusteriTipi.Ticari
            };

            Account account2 = new(bank, costumer2, 2000)
            {
                Balance = 2000,
                costumer = costumer2
            };


            Costumer costumer3 = new()
            {
                TCKimlikNo = 34567890120,
                Ad = "Emine",
                Soyad = "Kaya",
                Adres = "Ýzmir, Turkey",
                Telefon = "5553456789",
                MailAdresi = "eminekaya@example.com",
                MusteriTipi = Costumer.EMusteriTipi.Bireysel
            };

            Account account3 = new(bank, costumer3, 3000)
            {
                Balance = 3000,
                costumer = costumer3
            };
            Account account4 = new(bank, costumer1, 3000)
            {
                Balance = 4000,
                costumer = costumer1
            };

            Account account5 = new(bank, costumer1, 3000)
            {
                Balance = 5000,
                costumer = costumer1
            };

            bank.Costumers.Add(costumer1);
            bank.Costumers.Add(costumer2);
            bank.Costumers.Add(costumer3);

            Havale aliciHavale = new(bank, 459.0M, 450, account1, account3,
                        Islem.EIslemTipi.HavaleAl);

            Havale gonderenHavale = new(bank, 459.0M, 450, account1, account3,
                Islem.EIslemTipi.HavaleGonder);
            HavaleUcreti havaleUcreti = new(bank, account1, account3, 450);

            ParaYatirma paraYatir = new(bank, 400, account3);
            ParaCekme paracek = new(bank, 400, account2);

            InitializeComponent();
        }

        private void paraYatýrmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Para Yatýr")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Para_Yatir para_Yatir = new Para_Yatir(bank);
            para_Yatir.bank = this.bank;
            para_Yatir.MdiParent = this;
            para_Yatir.Show();
            
            
        }
        private void FormOtomasyon_Load(object sender, EventArgs e)
        {

        }

        private void paraCekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Para Çekme ")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Para_Cekme para_Cekme = new Para_Cekme(bank);
            para_Cekme.bank = this.bank;
            para_Cekme.MdiParent = this;
            para_Cekme.Show();
            

        }

        private void yeniHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Hesap Ekle")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Hesap_Ekle hesap_Ekle = new(bank);
            hesap_Ekle.bank = this.bank;
            hesap_Ekle.MdiParent = this;
            hesap_Ekle.Show();
              
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Havale Ýþlemleri")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Havale_Islemleri havale_Islemleri = new(bank);
            havale_Islemleri.bank = this.bank;
            havale_Islemleri.MdiParent = this;
            havale_Islemleri.Show();
            
            
        }

        private void yeniMusteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Müþteri Ekle")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Musteri_Ekle musteri_Ekle = new(bank);
            musteri_Ekle.bank = this.bank;
            musteri_Ekle.MdiParent = this;
            musteri_Ekle.Show();
            
            
        }

        private void musteriGuncelleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Müþteri Güncelle/Sil")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Musteri_Guncelle_Sil musteri_Guncelle_Sil = new(bank);
            musteri_Guncelle_Sil.bank = this.bank;
            musteri_Guncelle_Sil.MdiParent = this;
            musteri_Guncelle_Sil.Show();
            
            
        }

        private void hesapGuncelleSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Hesap Güncelle/Sil")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Hesap_Guncelle_Sil hesap_Guncelle_Sil = new(bank);
            hesap_Guncelle_Sil.bank = this.bank;
            hesap_Guncelle_Sil.MdiParent = this;
            hesap_Guncelle_Sil.Show();
            
        }

        private void HesapRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                string a = this.MdiChildren[i].Text;
                if (a == "Hesap Rapor")
                {
                    this.MdiChildren[i].Close();
                    break;
                }
            }
            Hesap_Rapor hesap_Rapor = new(bank,this);
            hesap_Rapor.bank = this.bank;
            hesap_Rapor.MdiParent = this;
            hesap_Rapor.Show();
            
        }

        private void bankaRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banka_Rapor banka_Rapor = new(bank);
            banka_Rapor.bank = this.bank;
            banka_Rapor.MdiParent = this;
            banka_Rapor.Show();
        }

        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanýcýÞifreDeðiþtirmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifre_Degistirme sifre_Degistirme = new Sifre_Degistirme(bank);
            sifre_Degistirme.bank = this.bank;
            sifre_Degistirme.MdiParent = this;
            sifre_Degistirme.Show();
        }
    }
}