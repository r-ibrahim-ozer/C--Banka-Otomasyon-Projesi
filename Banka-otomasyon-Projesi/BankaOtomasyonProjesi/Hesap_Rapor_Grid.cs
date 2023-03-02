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
    public partial class Hesap_Rapor_Grid : Form
    {
        public Bank bank { get; set; }
        public Account account { get; set; }
        public Form parentForm { get; set; }
        public DateTime raporBaslangic { get; set; }
        public DateTime raporBitis { get; set; }

        BindingSource bindingSource = new();

        public Hesap_Rapor_Grid(Bank _bank, Account account,Form parentForm)

        {
            bank = _bank;
            this.account = account;
            this.parentForm = parentForm;

            InitializeComponent();
        }


        private void Hesap_Rapor_Grid_Load(object sender, EventArgs e)
        {
            txtAd.Text = account.costumer.Ad;
            txtSoyad.Text = account.costumer.Soyad;
            txtMusteriNo.Text = "" + account.costumer.MusteriID;
            txtHesapNo.Text = "" + account.HesapID;
            txtBakiye.Text = "" + account.Balance;

            
            bank.GetIslem(account, raporBaslangic, raporBitis);
            txtraportarih.Text = DateTime.Now.ToString();
            txtTarihAralik.Text = raporBaslangic.ToString("yyyy/MM/dd/HH") + "-/-" + raporBitis.ToString("yyyy/MM/dd/HH");

            bindingSource.DataSource = bank.SelectedIslems;
            dataGridView1.DataSource = bindingSource;

            dataGridView1.Columns[0].HeaderText = "İşlem ID";
            dataGridView1.Columns[1].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns[2].HeaderText = "Bakiye";
            dataGridView1.Columns[3].HeaderText = "İşlem Tutarı";
            dataGridView1.Columns[4].HeaderText = "İşlem Tipi";
            dataGridView1.Columns[5].HeaderText = "Açıklama";

            dataGridView1.Columns[5].Width = 500;
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns["bank"].Visible = false;
            dataGridView1.Columns["Message"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
