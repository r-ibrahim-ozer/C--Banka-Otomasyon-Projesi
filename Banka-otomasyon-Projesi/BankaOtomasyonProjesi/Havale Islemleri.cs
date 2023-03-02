using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaOtomasyonProjesi
{
    public partial class Havale_Islemleri : Form
    {
        public Bank bank { get; set; }

        public Havale_Islemleri(Bank bank)
        {
            this.bank = bank;
            InitializeComponent();
        }
        
        private void Havale_Islemleri_Load(object sender, EventArgs e)
        {
            
        }

        // Gönderen hesap için hesap bilgilerini arama
        private void btnHavaleIslemonderenHesapAra_Click(object sender, EventArgs e)
        {
            
            if(txtHavaleIslemGonderenHesapNO.Text != "")
            {
                long _GonderenHesapID = long.Parse(txtHavaleIslemGonderenHesapNO.Text);
                
                 Account selectedAccount = bank.FindAccountWithHesapID(_GonderenHesapID);
                if (selectedAccount != null)
                {
                    txtHavaleIslemonderenHesapAd.Text = selectedAccount.costumer.Ad;
                    txtHavaleIslemonderenHesapSoyad.Text = selectedAccount.costumer.Soyad;
                    txtHavaleIslemonderenHesapBakiye.Text = "" + selectedAccount.Balance;
                    txtHavaleIslemGonderenHesapNONV.Text = "" + selectedAccount.HesapID;
                    txtHavaleIslemonderenHesapTipi.Text = "" + selectedAccount.costumer.MusteriTipi;

                }
                else MessageBox.Show("Lütfen Doğru Hesap numarasını girdiğinize emin olunuz.");
            }
            
           
        }

        // Alıcı hesap için hesap bilgilerini arama
        private void btnHavaleIslemAliciHesapAra_Click(object sender, EventArgs e)
        {
            if(txtHavaleIslemAliciHesapNo.Text != "")
            {
                long _AliciHesapID = long.Parse(txtHavaleIslemAliciHesapNo.Text);

                Account selectedAccount = bank.FindAccountWithHesapID(_AliciHesapID);
                if (selectedAccount != null)
                {
                    txtHavaleIslemAliciHesapAd.Text = selectedAccount.costumer.Ad;
                    txtHavaleIslemAliciHesapSoyad.Text = selectedAccount.costumer.Soyad;
                    txtHavaleIslemAliciHesapBakiye.Text = "" + selectedAccount.Balance;
                    txtHavaleIslemAliciHesapNoNV.Text = "" + selectedAccount.HesapID;
                    txtHavaleIslemAliciHesapTipi.Text = "" + selectedAccount.costumer.MusteriTipi;
                }
                else MessageBox.Show("Lütfen Doğru Hesap numarasını girdiğinize emin olunuz.");
            }


        }

        // Havale işleminin gerçekleştirilmesi
        private void btnHavaleIslemGonder_Click(object sender, EventArgs e)
        {
            if (txtHavaleIslemAliciHesapNoNV.Text != "" && txtHavaleIslemGonderenHesapNONV.Text != "")
            {
                if (txtHavaleIslemHavaleMiktar.Text != "")
                {
                    decimal islemtutar = Convert.ToDecimal(txtHavaleIslemHavaleToplamTutar.Text);
                    decimal miktar = Convert.ToDecimal(txtHavaleIslemHavaleMiktar.Text);


                    long aliciHesapNo = long.Parse(txtHavaleIslemAliciHesapNoNV.Text);
                    Account aliciAccount = bank.FindAccountWithHesapID(aliciHesapNo);

                    long gonderenHesapNo = long.Parse(txtHavaleIslemGonderenHesapNONV.Text);
                    Account gonderenAccount = bank.FindAccountWithHesapID(gonderenHesapNo);

                    Havale aliciHavale = new(bank, islemtutar, miktar, gonderenAccount, aliciAccount, 
                        Islem.EIslemTipi.HavaleAl);

                    Havale gonderenHavale = new(bank, islemtutar, miktar, gonderenAccount, aliciAccount, 
                        Islem.EIslemTipi.HavaleGonder);


                    if (gonderenHavale.IslemTutarı != 0)
                    {
                        HavaleUcreti havaleUcreti = new(bank, gonderenAccount,aliciAccount, miktar);
                    }
                   
                    txtHavaleIslemonderenHesapBakiye.Text = "" + gonderenAccount.Balance;
                    txtHavaleIslemAliciHesapBakiye.Text = "" + aliciAccount.Balance;
                    MessageBox.Show(gonderenHavale.Message);

                }
                else MessageBox.Show("Lütfen bir miktar giriniz.");
            }
            else MessageBox.Show("Lütfen Gönderen Hesap NO ve Alıcı Hesap NO" +
                "bilgilerini doğru girdiğinizden emin olunuz.");
        }


        // timer ile sürekli havale ücreti hesaplama
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(txtHavaleIslemonderenHesapTipi.Text != "" && txtHavaleIslemHavaleMiktar.Text != "")
            {
                string value = txtHavaleIslemHavaleMiktar.Text;
                long miktar = Convert.ToInt64(value);
                decimal havaleUcret = 0;
                if (txtHavaleIslemonderenHesapTipi.Text == "Bireysel") havaleUcret = Convert.ToDecimal(miktar) * Convert.ToDecimal(0.02F);
                
                txtHavaleIslemHavaleUcret.Text = havaleUcret.ToString();
                txtHavaleIslemHavaleToplamTutar.Text = (havaleUcret + long.Parse(value)).ToString();
            }
        }


    }
}
