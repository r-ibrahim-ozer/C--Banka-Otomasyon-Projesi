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
    public partial class Para_Yatir : Form
    {
        public Bank bank { get; set; }

        public Para_Yatir(Bank bank)
        {

            InitializeComponent();
        }

        private void Para_Yatir_Load(object sender, EventArgs e)
        {

        }

        private void btnParaYatirHesapNoAra_Click(object sender, EventArgs e)
        {
            if (txtParaYatirHesapNo.Text != "")
            {
                long hesapNo = long.Parse(txtParaYatirHesapNo.Text);
                Account account = bank.FindAccountWithHesapID(hesapNo);

                if (account != null)
                {
                    txtParaYatirAd.Text = account.costumer.Ad;
                    txtParaYatirKimlikNo.Text = "" + account.costumer.TCKimlikNo;
                    txtParaYatirSoyad.Text = account.costumer.Soyad;
                    txtParaYatirMusteriNo.Text = "" + account.costumer.MusteriID;
                    txtParaYatirBakiye.Text = "" + account.Balance;
                    txtParaYatirHesapNoNV.Text = "" + account.HesapID;

                    bank.HesapNoAraData(dataGridView1, account);

                }
                else MessageBox.Show("Hesap numarasını doğru girdiğinize emin olunuz.");
            }

        }

        private void btnParaYatirMusteriNoAra_Click(object sender, EventArgs e)
        {
            if (txtParaYatirMusteriNo.Text != "")
            {
                long musteriNo = long.Parse(txtParaYatirMusteriNo.Text);
                Costumer costumer = bank.FindCostumerWithMusteriID(musteriNo);
                if (costumer != null)
                {
                    txtParaYatirAd.Text = costumer.Ad;
                    txtParaYatirKimlikNo.Text = "" + costumer.TCKimlikNo;
                    txtParaYatirSoyad.Text = costumer.Soyad;
                    txtParaYatirMusteriNo.Text = ""+costumer.MusteriID;

                    bank.MusteriNoAraData(dataGridView1, costumer);

                }
                else MessageBox.Show("Müşteri numarasını doğru girdiğinize emin olunuz.");
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

            txtParaYatirAd.Text = account.costumer.Ad;
            txtParaYatirSoyad.Text = account.costumer.Soyad;
            txtParaYatirKimlikNo.Text = "" + account.costumer.TCKimlikNo;
            txtParaYatirBakiye.Text = "" + account.Balance;
            txtParaYatirHesapNo.Text = "" + account.HesapID;
            txtParaYatirHesapNoNV.Text = "" + account.HesapID; 
            txtParaYatirMusteriNo.Text = "" + account.costumer.MusteriID;
        }

        private void btnParaYatirYatir_Click(object sender, EventArgs e)
        {
            if (txtParaYatirHesapNoNV.Text != "")
            {
                long hesapNo = long.Parse(txtParaYatirHesapNoNV.Text);
                decimal tutar = Convert.ToDecimal(txtParaYatirTutar.Text);
                Account account = bank.FindAccountWithHesapID(hesapNo);

                if (account != null && tutar > 0)
                {

                    ParaYatirma paraYatir = new(bank, tutar, account);
                    bank.Islemdata(dataGridView1, paraYatir);
                    txtParaYatirBakiye.Text = "" + account.Balance;


                }
                else MessageBox.Show("Müşteri numarasını doğru girdiğinize ve bir tutar girdiğinize emin olunuz.");
            }
        }
    }
}
