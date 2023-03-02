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
    public partial class Sifre_Degistirme : Form
    {
        public Bank bank { get; set; }
        BindingSource bindingSource = new();


        public Sifre_Degistirme(Bank bank)
        {
            InitializeComponent();
            this.bank = bank;
        }

        private void Sifre_Degistirme_Load(object sender, EventArgs e)
        {
            txtKullanıcıAdi2.Text = bank.IsinUser.UserName;
            txtEskiSifre2.Text = bank.IsinUser.UserPassword;

            if (bank.IsinUser.UserName == "admin")
            {
                groupBox1.Visible = true;
                dataGridView1.Visible = true;
                bindingSource.DataSource = bank.Users;
                dataGridView1.DataSource = bindingSource;
                dataGridView1.Columns.Remove("bank");

            }


        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow row = new();

            row = dataGridView1.Rows[selectedRowIndex];

            string ad = row.Cells[0].Value.ToString();
            string sifre = row.Cells[1].Value.ToString();

            txtKullanıcıAdi2.Text = ad;
            txtEskiSifre2.Text = sifre;
            
        }

        private void btnTamam2_Click(object sender, EventArgs e)
        {
            string yenisifre = txtYeniSifre2.Text;

            foreach(User user in bank.Users)
            {
                if (user.UserName == txtKullanıcıAdi2.Text)
                {
                    user.UserPassword = yenisifre;
                }
            }
            bindingSource.DataSource = bank.Costumers;
            bindingSource.DataSource = bank.Users;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.Columns.Remove("bank");

            MessageBox.Show("İşlem başarıılı.");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool isValid = ((((txtEkleAd.Text.Length > 3 && txtEkleSifre.Text.Length > 3) && 
                (txtKimlikNo.Text.Length > 10 && txtAd.Text.Length > 1))
                && (txtSoyad.Text.Length > 1 && txtTelefon.Text.Length > 9)) &&
                 txtAdres.Text.Length > 1);

            if (isValid )
            {
                long kimlikNo = long.Parse(txtKimlikNo.Text);
                string ad = txtAd.Text;
                string soyad = txtSoyad.Text;
                string telefon = txtTelefon.Text;
                string adres = txtAdres.Text;
                string mail = txtMail.Text;
                string yenikad = txtEkleAd.Text;
                string yeniksifre = txtEkleSifre.Text;

                User yeni = new User(kimlikNo, ad, soyad, adres, telefon, mail, bank);
                yeni.UserName = yenikad;
                yeni.UserPassword = yeniksifre;

                bindingSource.DataSource = bank.Costumers;
                bindingSource.DataSource = bank.Users;
                dataGridView1.DataSource = bindingSource;
                dataGridView1.Columns.Remove("bank");

            }
            else MessageBox.Show("Bilgileri doğru girdiğinizden emin olunuz.");

        }
    }
}
