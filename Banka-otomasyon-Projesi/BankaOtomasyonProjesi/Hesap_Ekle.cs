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
    public partial class Hesap_Ekle : Form
    {
        public Bank bank { get; set; }
        BindingSource bindingSource = new();
        private Costumer _costumer;

        // Form üzerinde daha önce hesap eklenip eklenmemesini kontrolü
        bool IsHesapEklendi = false;



        public Hesap_Ekle(Bank _bank)
        {
            _bank = bank;

            InitializeComponent();
        }
        
        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            
           
        }


        // Var olan Müşterinin banka veri tabanına eklenmesi
        private void btnOlanMusteriEkle_Click(object sender, EventArgs e)
        {
            if (!IsHesapEklendi)
            {
                long musteriNo = long.Parse(txtOlanMusteriSoyadMusteriNoNV.Text);

                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);
                Account account = new(bank, costumer, 0);

                List<Account> list = new();
                list.Add(account);
                bindingSource.DataSource = list;
                dataGridView1.DataSource = bindingSource;

                dataGridView1.Columns["Balance"].HeaderText = "Bakiye";
                dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri No";
                dataGridView1.Columns["HesapID"].HeaderText = "Hesap No";
                dataGridView1.Columns["costumer"].Visible = false;
                dataGridView1.Columns["Islemiter"].Visible = false;
                
                IsHesapEklendi = true;
            }
            else MessageBox.Show("Hesap zaten eklendi");


        }

        // Var olan müşteri için bilgileri arama
        private void btnOlanMusteriAra_Click(object sender, EventArgs e)
        {
            
            if(txtOlanMusteriMusteriNo != null)
            {
                Costumer costumer = bank.FindCostumerWithMusteriID(long.Parse(txtOlanMusteriMusteriNo.Text));
                if (costumer != null)
                {
                    txtOlanMusteriKimlikNo.Text = costumer.TCKimlikNo.ToString();
                    txtOlanMusteriAd.Text = costumer.Ad;
                    txtOlanMusteriSoyad.Text = costumer.Soyad;
                    txtOlanMusteriHesapNo.Text = long.Parse(costumer.MusteriID.ToString("00000") + costumer.accID.ToString("000")).ToString();
                    txtOlanMusteriSoyadMusteriNoNV.Text = "" + costumer.MusteriID;                }
                else MessageBox.Show("Böyle bir hesap bulunmamaktadır.");
            }           
        }


        // Yeni müşteri oluşturma
        private void btnHesapEkleYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            bool isVaild = txtHesapEkleYeniMusteriKimlikNo.Text.Length > 10 && txtHesapEkleYeniMusteriAd.Text .Length > 1
                && txtHesapEkleYeniMusteriSoyad.Text.Length > 1 && txtHesapEkleYeniMusteriTelefon.Text.Length > 9 &&
                txtHesapEkleYeniMusteriTipi.Text.Length > 1 && txtHesapEkleYeniMusteriAdres.Text.Length >1;
            if (isVaild)
            {
                long kimlikNo = long.Parse(txtHesapEkleYeniMusteriKimlikNo.Text);
                string ad = txtHesapEkleYeniMusteriAd.Text;
                string soyad = txtHesapEkleYeniMusteriSoyad.Text;
                string telefon = txtHesapEkleYeniMusteriTelefon.Text;
                string tip = txtHesapEkleYeniMusteriTipi.Text;
                string adres = txtHesapEkleYeniMusteriAdres.Text;
                string mail = txtHesapEkleYeniMusteriMail.Text;
                Costumer costumer = new(kimlikNo, ad, soyad, adres, telefon, mail, tip,bank);
                txtHesapEkleYeniMusteriMusteriNo.Text = "" + costumer.MusteriID;
                _costumer=costumer;
                bank.ShowCostumerdata(dataGridView2, costumer);

            }
            else MessageBox.Show("Bilgileri doğru girdiğinizden emin olunuz.");
        }


        // yeni müşteri oluşturduktan sonra hesap ekleme işlemi için devam etme işlemi
        private void btnYeniMusteriDevamEt_Click(object sender, EventArgs e)
        {
            if (txtHesapEkleYeniMusteriMusteriNo.Text != "")
            {
                panel2.BringToFront();
                txtHesapEkleYeniMusteriAd2.Text = _costumer.Ad;
                txtHesapEkleYeniMusteriSoyad2.Text = _costumer.Soyad;
                txtHesapEkleYeniMusteriKimlikNo2.Text = "" + _costumer.TCKimlikNo;
                txtHesapEkleYeniMusteriMusteriNo2.Text = "" + _costumer.MusteriID;

            }
            else MessageBox.Show("Lütfen önce müşteriyi kaydediniz.");
        }



        // oluşturulan yeni müşteri için yeni hesap oluşturma
        private void btnHesapEkleYeniMusteriHesapEkle_Click(object sender, EventArgs e)
        {
            if (!IsHesapEklendi)
            {
                Account account = new(this.bank, _costumer, 0);
                HesapAcma hesapEkle = new(bank, account);

                bindingSource.DataSource = bank.Costumers;
                bindingSource.DataSource = account;
                dataGridView3.DataSource = bindingSource;

                dataGridView3.Columns["Balance"].HeaderText = "Bakiye";
                dataGridView3.Columns["MusteriID"].HeaderText = "Müşteri No";
                dataGridView3.Columns["HesapID"].HeaderText = "Hesap No";
                dataGridView3.Columns["costumer"].Visible = false;
                dataGridView3.Columns["Islemiter"].Visible = false;
                IsHesapEklendi = true;
                txtHesapEkleYeniMusteriHesapNo2.Text ="" + account.HesapID;
            }
            else MessageBox.Show("Hesap zaten eklendi");
        }
    }
}
