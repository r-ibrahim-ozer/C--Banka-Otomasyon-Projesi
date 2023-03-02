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
    public partial class Banka_Rapor : Form
    {
        BindingSource bindingSource = new();
        public Bank bank { get; set; }
        public Form parentForm { get; set; }


        public Banka_Rapor(Bank _bank)
        {
            bank = _bank;
            InitializeComponent();

            // Banka tüm müşterilerin gridde gösterimi
            dataGridView2.DataSource = bank.Costumers;
            dataGridView2.Columns["MusteriID"].HeaderText = "Müşteri No";
            dataGridView2.Columns["MusteriTipi"].HeaderText = "Müşteri Tipi";
            dataGridView2.Columns["TCKimlikNo"].HeaderText = "TC Kimlik No";
            dataGridView2.Columns["MailAdresi"].HeaderText = "Mail Adresi";
            dataGridView2.Columns["bank"].Visible = false;
            dataGridView2.Columns["accID"].Visible = false;

            // Banka tüm hesapların gridde gösterimi
            dataGridView3.DataSource = bank.AllAccounts;
            dataGridView3.Columns["Balance"].HeaderText = "Bakiye";
            dataGridView3.Columns["MusteriID"].HeaderText = "Müşteri No";
            dataGridView3.Columns["HesapID"].HeaderText = "Hesap No";
            dataGridView3.Columns["costumer"].Visible = false;
            dataGridView3.Columns["Islemiter"].Visible = false;

            decimal toplam = 0;
            foreach (Account account in bank.AllAccounts)
            {
                toplam += account.Balance;
            }
            txtBulunanPara.Text = "" + toplam;

        }

        private void Banka_Rapor_Load(object sender, EventArgs e)
        {

        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            txtBulunanPara.Text = "";
            txtGelenPara.Text = "";
            txtGidenPara.Text = "";
            txtHavaleKazanç.Text = "";

            DateTime baslangic = dtpBaslangic.Value;
            DateTime bitis = dtpBitis.Value;
            string islemTip = comboBoxIslemTipi.Text;

            if (islemTip == "Para Yatırma") islemTip = "ParaYatirma";
            else if (islemTip == "Para Çekme") islemTip = "ParaCekme";
            else if (islemTip == "Havale Al") islemTip = "HavaleAl";
            else if (islemTip == "Havale Gönder") islemTip = "HavaleGonder";
            else if (islemTip == "Havale Ücreti") islemTip = "HavaleUcreti";

            dataGridView1.DataSource = null;


            if (baslangic < bitis) bank.GetIslem(islemTip, baslangic, bitis);
            else MessageBox.Show("Başlangıç zamanı bitiş zamannından büyük olamaz");

            if (bank.SelectedIslems.Count > 0)
            {
                decimal gidenPara = 0;
                decimal gelenPara = 0;
                decimal havaleKazanc = 0;

                foreach(Islem islem in bank.SelectedIslems)
                {
                    if (islem.IslemTipi == Islem.EIslemTipi.ParaYatirma) gelenPara += islem.IslemTutarı;
                    else if (islem.IslemTipi == Islem.EIslemTipi.ParaCekme) gidenPara += islem.IslemTutarı;
                    else if (islem.IslemTipi == Islem.EIslemTipi.HavaleUcreti) havaleKazanc += islem.IslemTutarı;
                }
                

                txtGelenPara.Text = "" + gelenPara; 
                txtGidenPara.Text = "" + gidenPara;
                txtHavaleKazanç.Text = "" + havaleKazanc;


                bindingSource.DataSource = bank.SelectedIslems;
                dataGridView1.DataSource = bindingSource;

                dataGridView1.Columns["IslemID"].HeaderText = "İşlem ID";
                dataGridView1.Columns[1].HeaderText = "İşlem Tarihi";
                dataGridView1.Columns[3].HeaderText = "Bakiye";
                dataGridView1.Columns[2].HeaderText = "İşlem Tutarı";
                dataGridView1.Columns[4].HeaderText = "İşlem Tipi";
                dataGridView1.Columns[5].HeaderText = "Açıklama";

                dataGridView1.Columns[5].Width = 550;
                dataGridView1.Columns[0].Width = 250;
                dataGridView1.Columns["bank"].Visible = false;
                dataGridView1.Columns["Message"].Visible = false;


            }
            else MessageBox.Show("Belirtilen kriterde işlem bulunamadı");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
