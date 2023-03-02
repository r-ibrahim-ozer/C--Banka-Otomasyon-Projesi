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

namespace BankaOtomasyonProjesi
{
    public partial class Para_Cekme : Form
    {
        public Bank bank { get; set; }

        public Para_Cekme(Bank _bank)
        {
            bank = _bank;
            InitializeComponent();
        }

        private void btnParaCekmeHesapNoAra1_Click(object sender, EventArgs e)
        {
            if (txtParaCekmeHesapNo.Text != null)
            {
                long hesapNo = long.Parse(txtParaCekmeHesapNo.Text);
                Account acount = bank.FindAccountWithHesapID(hesapNo);
                if (acount != null)
                {
                    txtParaCekmeMusteriNo.Text = "" + acount.costumer.MusteriID;
                    txtParaCekmeKimlikNo.Text = "" + acount.costumer.TCKimlikNo;
                    txtParaCekmeAd.Text = acount.costumer.Ad;
                    txtParaCekmeSoyad.Text = acount.costumer.Soyad;
                    txtParaCekmeBakiye.Text = "" + acount.Balance;
                    txtParaCekmeHesapNoNV.Text = "" + acount.HesapID;

                    bank.HesapNoAraData(dataGridView1, acount);

                }
                else MessageBox.Show("Böyle bir hesap bulunmamaktadır.");
            }
            
            
        }

        private void btnParaCekmeMusteriNoAra_Click(object sender, EventArgs e)
        {
            if (txtParaCekmeHesapNo.Text != null)
            {
                long musteriNo = long.Parse(txtParaCekmeMusteriNo.Text);

                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);
                if (costumer != null)
                {
                    txtParaCekmeMusteriNo.Text = "" + costumer.MusteriID;
                    txtParaCekmeKimlikNo.Text = "" + costumer.TCKimlikNo;
                    txtParaCekmeAd.Text = costumer.Ad;
                    txtParaCekmeSoyad.Text = costumer.Soyad;

                    bank.MusteriNoAraData(dataGridView1, costumer);

                }
                else MessageBox.Show("Böyle bir müşteri bulunmamaktadır.");
            }
        }

        private void btnParaCekmeCek_Click(object sender, EventArgs e)
        {
            if (txtParaCekmeHesapNoNV.Text != "")
            {
                if (txtParaCekmeMiktar.Text != "")
                {
                    decimal miktar = Convert.ToDecimal(txtParaCekmeMiktar.Text);
                    long hesapNo = long.Parse(txtParaCekmeHesapNoNV.Text);

                    Account account = bank.FindAccountWithHesapID(hesapNo);

                    if (account.IsPermitedToParaCekme(miktar))
                    {
                        ParaCekme paraCek = new(bank, miktar, account);
                        bank.Islemdata(dataGridView1, paraCek);

                        txtParaCekmeBakiye.Text = "" + account.Balance;
                        MessageBox.Show(paraCek.Message);
                        if(paraCek.Message == "Yeterli Bakiye Bulunmamakta")
                        {
                            MessageBox.Show("Ek hesap seçiniz.");

                            bank.MusteriNoAraData(dataGridView2, account.costumer);
                            dataGridView2.BringToFront();

                        }

                    }
                    else MessageBox.Show("Hesaplar günlük para çekme limiti olan 750TL'yi aşamaz.");

                }
                else MessageBox.Show("Lütfen bir miktar giriniz.");
            }
            else if (txtParaCekmeHesapNoNV.Text != "") MessageBox.Show("Lütfen bir hesap seçiniz.");
            else MessageBox.Show("Lütfen Gönderen Hesap NO" +
                "bilgilerini doğru girdiğinizden emin olunuz.");
        }

        private void Para_Cekme1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = new();

            row = dataGridView1.Rows[selectedRowIndex];

            string hesapNo = row.Cells[1].Value.ToString();
            long _hesapNo = long.Parse(hesapNo);
            Account account = bank.FindAccountWithHesapID(_hesapNo);


            txtParaCekmeAd.Text = account.costumer.Ad;
            txtParaCekmeSoyad.Text = account.costumer.Soyad;
            txtParaCekmeKimlikNo.Text = "" + account.costumer.TCKimlikNo;
            txtParaCekmeBakiye.Text = "" + account.Balance;
            txtParaCekmeHesapNo.Text = "" + account.HesapID;
            txtParaCekmeHesapNoNV.Text = "" + account.HesapID;
            txtParaCekmeMusteriNo.Text = "" + account.costumer.MusteriID;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = new();

            row = dataGridView1.Rows[selectedRowIndex];

            string hesapNo = row.Cells[1].Value.ToString();
            long _hesapNo = long.Parse(hesapNo);
            Account account = bank.FindAccountWithHesapID(_hesapNo);

            txtEkHesapNo.Text =""+ account.HesapID;
            lblEkHesapNo.Visible = true;
            txtEkHesapNo.Visible = true;
            btnEkHesapileCek.Visible = true;
            txtParaCekmeMiktar.ReadOnly = true;
        }

        private void btnEkHesapileCek_Click(object sender, EventArgs e)
        {
            if (txtEkHesapNo.Text != null && txtEkHesapNo.Text != txtParaCekmeHesapNoNV.Text)
            {
                decimal miktar = Convert.ToDecimal(txtParaCekmeMiktar.Text);
                long anahesapNo = long.Parse(txtParaCekmeHesapNoNV.Text);
                long ekhesapNo = long.Parse(txtEkHesapNo.Text);
                decimal bakiye = Convert.ToDecimal(txtParaCekmeBakiye.Text);

                decimal anaHesapMiktar = bakiye;
                decimal ekHesapMiktar = miktar - bakiye;

                Account anaaccount = bank.FindAccountWithHesapID(anahesapNo);
                Account ekaccount = bank.FindAccountWithHesapID(ekhesapNo);

                if (anaaccount.IsPermitedToParaCekme(anaHesapMiktar))
                {
                    ParaCekme paraCek = new(bank, anaHesapMiktar, anaaccount);

                    txtParaCekmeBakiye.Text = "" + anaaccount.Balance;
                    MessageBox.Show(paraCek.Message);

                    if (paraCek.Message == "İşlem Başarılı" && ekaccount.IsPermitedToParaCekme(miktar))
                    {
                        ParaCekme ekparaCek = new(bank, ekHesapMiktar, ekaccount);

                        txtParaCekmeBakiye.Text = "" + ekaccount.Balance;
                        MessageBox.Show(ekparaCek.Message);

                    }
                    else MessageBox.Show("Hesaplar günlük para çekme limiti olan 750TL'yi aşamaz.");
                }
                else MessageBox.Show("Hesaplar günlük para çekme limiti olan 750TL'yi aşamaz.");
            }
        }
    }
}
