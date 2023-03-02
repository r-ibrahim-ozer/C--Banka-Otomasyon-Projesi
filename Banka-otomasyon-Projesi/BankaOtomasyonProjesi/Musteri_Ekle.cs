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
    public partial class Musteri_Ekle : Form
    {
        public Bank bank { get; set; }
        public bool IsMusteriEklendi = false;


        public Musteri_Ekle(Bank bank)
        {
            InitializeComponent();
        }

        private void MüsteriEkle_Load(object sender, EventArgs e)
        {

        }


        private void btnMusteriEkleEkle_Click(object sender, EventArgs e)
        {
            bool isValid = (((txtMusteriEkleKimlikNo.Text.Length > 10 && txtMusteriEkleAd.Text.Length > 1)
                && (txtMusteriEkleSoyad.Text.Length > 1 && txtMusteriEkleTelefon.Text.Length > 9)) &&
                txtMusteriEkleTip.Text.Length > 1 && txtMusteriEkleAdres.Text.Length > 1);

            if (isValid && !IsMusteriEklendi)
            {
                long kimlikNo = long.Parse(txtMusteriEkleKimlikNo.Text);
                string ad = txtMusteriEkleAd.Text;
                string soyad = txtMusteriEkleSoyad.Text;
                string telefon = txtMusteriEkleTelefon.Text;
                string tip = txtMusteriEkleTip.Text;
                string adres = txtMusteriEkleAdres.Text;
                string mail = txtMusteriEkleMail.Text;
                Costumer costumer = new(kimlikNo, ad, soyad, adres, telefon, mail, tip, bank);
                txtMusteriEkleMusteriNo.Text = "" + costumer.MusteriID;

                bank.ShowCostumerdata(dataGridView1, costumer);
                IsMusteriEklendi = true;

            }
            else MessageBox.Show("Bilgileri doğru girdiğinizden emin olunuz.");
        }
    }
}
