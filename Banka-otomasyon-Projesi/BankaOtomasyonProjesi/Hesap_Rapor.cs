using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaOtomasyonProjesi
{
    public partial class Hesap_Rapor : Form
    {
        BindingSource bindingSource = new();
        public Bank bank { get; set; }
        public Form parentForm { get; set; }

        public Hesap_Rapor(Bank _bank, Form parentForm)
        {
            bank = _bank;
            this.parentForm = parentForm;

            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void Hesap_Rapor_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapRaporMusteriNoAra_Click(object sender, EventArgs e)
        {
            if (txtHesapRaporMusteriNo.Text != "")
            {
                long musteriNo = long.Parse(txtHesapRaporMusteriNo.Text);
                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);
                if (costumer != null)
                {
                    txtHesapRaporAd.Text = costumer.Ad;
                    txtHesapRaporKimlikNp.Text = "" + costumer.TCKimlikNo;
                    txtHesapRaporSoyad.Text = costumer.Soyad;

                    bank.MusteriNoAraData(dataGridView1, costumer);

                }
                else MessageBox.Show("Müşteri numarasını doğru girdiğinize emin olunuz.");
            }
        }

        private void btnHesapRaporlHesapNoAra_Click(object sender, EventArgs e)
        {
            if (txtHesapRaporHesapNo.Text != "")
            {
                long hesapNo = long.Parse(txtHesapRaporHesapNo.Text);
                Account account = bank.FindAccountWithHesapID(hesapNo);

                if (account != null)
                {
                    txtHesapRaporAd.Text = account.costumer.Ad;
                    txtHesapRaporKimlikNp.Text = "" + account.costumer.TCKimlikNo;
                    txtHesapRaporSoyad.Text = account.costumer.Soyad;
                    txtHesapRaporMusteriNo.Text = "" + account.costumer.MusteriID;
                    txtHesapRaporBakiye.Text = "" + account.Balance;
                    txtHesapRaporHesapNoNV.Text = "" + account.HesapID;

                    bank.HesapNoAraData(dataGridView1, account);
                    
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


            txtHesapRaporAd.Text = account.costumer.Ad;
            txtHesapRaporSoyad.Text = account.costumer.Soyad;
            txtHesapRaporKimlikNp.Text = "" + account.costumer.TCKimlikNo;
            txtHesapRaporBakiye.Text = "" + account.Balance;
            txtHesapRaporHesapNo.Text = "" + account.HesapID;
            txtHesapRaporHesapNoNV.Text = "" + account.HesapID;
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            if (txtHesapRaporHesapNoNV.Text != "")
            {
                DateTime raporBaslagic = dtpRaporBaslangic.Value;
                DateTime raporBitis = dtpRaporBitis.Value;

                if (raporBaslagic < raporBitis)
                {
                    long hesapNo = long.Parse(txtHesapRaporHesapNoNV.Text);
                    Account account = bank.FindAccountWithHesapID(hesapNo);

                    bank.GetIslem(account, raporBaslagic, raporBitis);
                    Hesap_Rapor_Grid hesap_Rapor_Grid = new(bank, account, this.parentForm);
                    hesap_Rapor_Grid.bank = this.bank;
                    hesap_Rapor_Grid.raporBaslangic = raporBaslagic;
                    hesap_Rapor_Grid.raporBitis = raporBitis;
                    hesap_Rapor_Grid.MdiParent = parentForm;
                    hesap_Rapor_Grid.Show();
                } 
                else MessageBox.Show("Başlangıç tarihi bitiş tarihinden büyük olamaz.");
            }
            else MessageBox.Show("Lütfen bir hesap seçiniz.");
        }
    }
}
