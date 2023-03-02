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
    public partial class Hesap_Guncelle_Sil : Form
    {
        public Bank bank { get; set; }
        BindingSource bindingSource = new();


        public Hesap_Guncelle_Sil(Bank _bank)
        {
            bank = _bank;
            
            InitializeComponent();
        }

        private void HesapGuncelleSil_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapGuncelleSilMusteriNoAra_Click(object sender, EventArgs e)
        {
            if(txtHesapGuncelleSilMusteriNo.Text != "")
            {
                long musteriNo = long.Parse(txtHesapGuncelleSilMusteriNo.Text);
                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);
                if (costumer != null)
                {
                    txtHesapGuncelleSilAd.Text = costumer.Ad;
                    txtHesapGuncelleSilKimlikNp.Text = "" + costumer.TCKimlikNo;
                    txtHesapGuncelleSilSoyad.Text = costumer.Soyad;



                    bindingSource.DataSource = bank.Costumers;
                    bindingSource.DataSource = costumer.accounts;
                    dataGridView1.DataSource = bindingSource;

                    dataGridView1.Columns["Balance"].HeaderText = "Bakiye";
                    dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri No";
                    dataGridView1.Columns["HesapID"].HeaderText = "Hesap No";
                    dataGridView1.Columns["costumer"].Visible = false;
                    dataGridView1.Columns["Islemiter"].Visible = false;

                }
                else MessageBox.Show("Müşteri numarasını doğru girdiğinize emin olunuz.");
            }
        }

        private void btnHesapGuncelleSilHesapNoAra_Click(object sender, EventArgs e)
        {
            if (txtHesapGuncelleSilHesapNo.Text != "")
            {
                long hesapNo = long.Parse(txtHesapGuncelleSilHesapNo.Text);
                Account account = bank.FindAccountWithHesapID(hesapNo);

                if (account != null)
                {
                    txtHesapGuncelleSilAd.Text = account.costumer.Ad;
                    txtHesapGuncelleSilKimlikNp.Text = "" + account.costumer.TCKimlikNo;
                    txtHesapGuncelleSilSoyad.Text = account.costumer.Soyad;
                    txtHesapGuncelleSilMusteriNo.Text = "" + account.costumer.MusteriID;
                    txtHesapGuncelleSilBakiye.Text = "" + account.Balance;
                    txtHesapGuncelleSilHesapNoNV.Text =""+ account.HesapID;

                    bindingSource.DataSource = bank.Costumers;
                    bindingSource.DataSource = account;
                    dataGridView1.DataSource = bindingSource;

                    dataGridView1.Columns["Balance"].HeaderText = "Bakiye";
                    dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri No";
                    dataGridView1.Columns["HesapID"].HeaderText = "Hesap No";
                    dataGridView1.Columns["costumer"].Visible = false;
                    dataGridView1.Columns["Islemiter"].Visible = false;
                }
                else MessageBox.Show("Hesap numarasını doğru girdiğinize emin olunuz.");    
            }
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = new();

            row = dataGridView1.Rows[selectedRowIndex];

            string hesapNo = row.Cells[1].Value.ToString();
            long _hesapNo = long.Parse(hesapNo);
            Account account = bank.FindAccountWithHesapID(_hesapNo);


            txtHesapGuncelleSilAd.Text = account.costumer.Ad;
            txtHesapGuncelleSilSoyad.Text = account.costumer.Soyad;
            txtHesapGuncelleSilKimlikNp.Text = ""+ account.costumer.TCKimlikNo;
            txtHesapGuncelleSilBakiye.Text = "" + account.Balance;
            txtHesapGuncelleSilHesapNo.Text = "" + account.HesapID;
            txtHesapGuncelleSilHesapNoNV.Text = "" + account.HesapID;

        }

        private void btnHesapGuncelleSilSil_Click(object sender, EventArgs e)
        {
            if (txtHesapGuncelleSilHesapNoNV.Text != "" && Convert.ToDecimal(txtHesapGuncelleSilBakiye.Text) == 0)
            {
                long hesapNo = long.Parse(txtHesapGuncelleSilHesapNoNV.Text);
                Account account = bank.FindAccountWithHesapID(hesapNo);
                if (account != null)
                {
                    Costumer costumer = account.costumer;

                    bank.AllAccounts.Remove(account);
                    costumer.accounts.Remove(account);
                    bindingSource.DataSource = bank.Costumers;
                    bindingSource.DataSource = costumer.accounts;
                    dataGridView1.DataSource = bindingSource;

                    dataGridView1.Columns["Balance"].HeaderText = "Bakiye";
                    dataGridView1.Columns["MusteriID"].HeaderText = "Müşteri No";
                    dataGridView1.Columns["HesapID"].HeaderText = "Hesap No";
                    dataGridView1.Columns["costumer"].Visible = false;
                    dataGridView1.Columns["Islemiter"].Visible = false;

                    txtHesapGuncelleSilHesapNoNV.Text = "";

                }    
            }
            else if (Convert.ToDecimal(txtHesapGuncelleSilBakiye.Text) >= 0) MessageBox.Show("Bakiye sıfır olmadan hesap kapatılamaz.");
            else MessageBox.Show("Bir Hesap seçildiğine emin olunuz.");
        }
    }
}
