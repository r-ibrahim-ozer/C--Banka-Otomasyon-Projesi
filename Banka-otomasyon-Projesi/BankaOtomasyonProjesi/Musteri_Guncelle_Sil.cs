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
    public partial class Musteri_Guncelle_Sil : Form
    {
        public Bank bank { get; set; }
        BindingSource bindingSource = new();
        private Costumer _costumer;


        public Musteri_Guncelle_Sil(Bank bank)
        {
            InitializeComponent();
        }


        private void Musteri_Guncelle_Sil_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMusteriGuncelleSilGuncelle_Click(object sender, EventArgs e)
        {
            bool isValid = txtMusteriGuncelleSilKimlikNo.Text.Length > 10 && txtMusteriGuncelleSilAd.Text.Length > 1
               && txtMusteriGuncelleSilSoyad.Text.Length > 1 && txtMusteriGuncelleSilTelefon.Text.Length > 9 &&
               txtMusteriGuncelleSilTip.Text.Length > 1 && txtMusteriGuncelleSilAdres.Text.Length > 1;

            if (isValid)
            {
                long kimlikNo = long.Parse(txtMusteriGuncelleSilKimlikNo.Text);
                string ad = txtMusteriGuncelleSilAd.Text;
                string soyad = txtMusteriGuncelleSilSoyad.Text;
                string telefon = txtMusteriGuncelleSilTelefon.Text;
                string tip = txtMusteriGuncelleSilTip.Text;
                string adres = txtMusteriGuncelleSilAdres.Text;
                string mail = txtMusteriGuncelleSilMail.Text;

                _costumer.TCKimlikNo = kimlikNo;
                _costumer.Ad = ad;
                _costumer.Soyad = soyad;
                _costumer.Telefon = telefon;
                _costumer.Adres= adres;
                _costumer.MailAdresi= mail;
                _costumer.MusteriTipi = Costumer.EMusteriTipi.Bireysel;
                if(tip=="Ticari") _costumer.MusteriTipi = Costumer.EMusteriTipi.Ticari;

                MessageBox.Show("Başarıyla güncellendi");
                bank.ShowCostumerdata(dataGridView1, _costumer);

            }
        }

        private void btnMusteriGuncelleSilMusteriNoAra_Click(object sender, EventArgs e)
        {
            if (txtMusteriGuncelleSilMusteriNo.Text != "")
            {
                long musteriNo = long.Parse(txtMusteriGuncelleSilMusteriNo.Text);
                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);
                if (costumer != null)
                {
                    txtMusteriGuncelleSilAd.Text = costumer.Ad;
                    txtMusteriGuncelleSilKimlikNo.Text = "" + costumer.TCKimlikNo;
                    txtMusteriGuncelleSilSoyad.Text = costumer.Soyad;
                    txtMusteriGuncelleSilMusteriNo.Text =""+ costumer.MusteriID;
                    txtMusteriGuncelleSilAdres.Text = costumer.Adres;
                    txtMusteriGuncelleSilMail.Text = costumer.MailAdresi;
                    txtMusteriGuncelleSilTelefon.Text = costumer.Telefon;
                    txtMusteriGuncelleSilTip.Text = costumer.MusteriTipi.ToString();
                    txtMusteriGuncelleSilMusteriNoNV.Text = "" + costumer.MusteriID;

                    bank.ShowCostumerdata(dataGridView1, costumer);

                    _costumer=costumer;

                }
                else MessageBox.Show("Müşteri numarasını doğru girdiğinize emin olunuz.");
            }
        }

        private void btnMusteriGuncelleSilKimlikNoAra_Click(object sender, EventArgs e)
        {
            if (txtMusteriGuncelleSilMusteriNo.Text != "")
            {
                long kimlikNo = long.Parse(txtMusteriGuncelleSilKimlikNo.Text);
                Costumer costumer = null;
                foreach(Costumer _costumer in bank.Costumers)
                {
                    if (_costumer.TCKimlikNo == kimlikNo) { costumer = _costumer; break; }
                }
                if (costumer != null)
                {
                    txtMusteriGuncelleSilAd.Text = costumer.Ad;
                    txtMusteriGuncelleSilKimlikNo.Text = "" + costumer.TCKimlikNo;
                    txtMusteriGuncelleSilSoyad.Text = costumer.Soyad;
                    txtMusteriGuncelleSilMusteriNo.Text = "" + costumer.MusteriID;
                    txtMusteriGuncelleSilAdres.Text = costumer.Adres;
                    txtMusteriGuncelleSilMail.Text = costumer.MailAdresi;
                    txtMusteriGuncelleSilTelefon.Text = costumer.Telefon;
                    txtMusteriGuncelleSilTip.Text = costumer.MusteriTipi.ToString();
                    txtMusteriGuncelleSilMusteriNoNV.Text = ""+costumer.MusteriID;

                    bank.ShowCostumerdata(dataGridView1, costumer);
      
                    _costumer = costumer;
                }
                else MessageBox.Show("Kimlik numarasını doğru girdiğinize emin olunuz.");
            }
        }

        private void btnMusteriGuncelleSilSil_Click(object sender, EventArgs e)
        {
            if (txtMusteriGuncelleSilMusteriNoNV.Text != "")
            {
                long musteriNo = long.Parse(txtMusteriGuncelleSilMusteriNoNV.Text);
                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);

                decimal cBalance = 0;
                foreach(Account account in costumer.accounts)
                {
                    cBalance+=account.Balance;
                }
                if (cBalance == 0)
                {
                    foreach (Account account in costumer.accounts)
                    {
                        bank.AllAccounts.Remove(account);
                    }
                    bank.Costumers.Remove(costumer);
                  
                    bindingSource.DataSource = null;
                    dataGridView1.DataSource = bindingSource;
                }
                else MessageBox.Show("Müşteri üzerine kayıtlı hesaplar içindeki bakiyeyi sıfırlayınız.");

               
            }
        }
    }
}
