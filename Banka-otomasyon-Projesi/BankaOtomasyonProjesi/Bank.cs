using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaOtomasyonProjesi
{
    public class Bank
    {
        public string Name { get; set; }
        public decimal BankaGelir { get; set; }
        public User IsinUser { get; set; }  // Sistemi kullanan kullanıcın kimliğini tutar

        // Banka tüm kayıtlıların listeleri
        public List<Costumer> Costumers { get; set; } = new();
        public List<Account> AllAccounts { get; set; } = new();
        public List<Islem> AllIslems { get; set; } = new();
        public List<Islem> SelectedIslems { get; set; } = new();  // datagrid'e rapor oluşturmak için seçilen kayıtların listesi
        public List<User> Users { get; set; } = new();  // Sisteme giriş izni bulunan kullanıcıların kimliğini tutar


        //Accounts listesinde HesapId'ye göre arama
        public Account FindAccountWithHesapID(long _HesapID)
        {
            bool found = false;
            Account selectedAccount = null;
            foreach (Account account in AllAccounts)
            {
                if (account.HesapID == _HesapID)
                {
                    selectedAccount = account;
                    found = true;
                    break;
                }
            }
            if (found) return selectedAccount;
            else return null;

        }

        //Costumer listesinde MüşretiId'ye göre arama
        public Costumer FindCostumerWithMusteriID(long _MusteriID)
        {
            bool found = false;
            Costumer selectedCostumer = Costumers[0];
            foreach (Costumer costumer in Costumers)
            {
                if (costumer.MusteriID == _MusteriID)
                {
                    selectedCostumer = costumer;
                    found = true;
                    break;
                }
            }
            if (found) return selectedCostumer;
            else return null;
        }

        // Belirtilen hesabın belirtilen aralıktaki işlemlerini selectedislems listesine atar.
        public void GetIslem(Account account, DateTime baslangic, DateTime bitis)
        {
            SelectedIslems.Clear();

            foreach (Islem islem in account.Islemler)
            {
                if (islem.IslemTarih < bitis && islem.IslemTarih > baslangic)
                {
                    SelectedIslems.Add(islem);
                }
            }
        }

        // Belirtilen işlem türünün belirtilen işlemlerini selectedislems listesine atar.
        public void GetIslem(string text,DateTime baslangic,DateTime bitis)
        {
            decimal ToplamGiden = 0;
            decimal ToplamGelen = 0;
            decimal BankaGelir = 0;

            SelectedIslems.Clear();

            foreach(Islem islem in AllIslems)
            {
                if(islem.IslemTarih < bitis && islem.IslemTarih > baslangic)
                {
                    if (islem.IslemTipi.ToString() == text)
                    {
                        SelectedIslems.Add(islem);
                    }
                    else if (text == "Genel")
                    {
                        SelectedIslems.Add(islem);
                    }

                    if (islem.IslemTipi.ToString() == "ParaCekme")
                    {
                        ToplamGiden += islem.IslemTutarı;
                    }

                    else if (islem.IslemTipi.ToString() == "ParaYatirma")
                    {
                        ToplamGelen += islem.IslemTutarı;
                    }

                    else if (islem.IslemTipi.ToString() == "HavaleAl")
                    {
                        BankaGelir += islem.IslemTutarı;
                    }
                }
                
            }

        }

        //kullanıcı giriş yaparken bilgileni kontrol eder ve isinuser özelliğine kullanıcıyı atar.
        public bool CheckUser(string name,string password)
        {
            bool isValid = false;
            foreach(User user in Users)
            {
                if(user.UserName==name && user.UserPassword == password)
                {
                    this.IsinUser = user;
                    isValid =true;
                    break ;
                }

            }
            return isValid;
        }

        //datagridde hesap no ile aranan hesabı gösterir
        public void HesapNoAraData(DataGridView dataGridView,Account account)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(account);

            //bindingSource.DataSource = acount;
            dataGridView.DataSource = accounts;
            dataGridView.BringToFront();

            dataGridView.Columns["Balance"].HeaderText = "Bakiye";
            dataGridView.Columns["MusteriID"].HeaderText = "Müşteri No";
            dataGridView.Columns["HesapID"].HeaderText = "Hesap No";
            dataGridView.Columns["costumer"].Visible = false;
            dataGridView.Columns["Islemiter"].Visible = false;
        }

        //datagridde müşteri no ile aranan hesabı gösterir
        public void MusteriNoAraData(DataGridView dataGridView,Costumer costumer)
        {
            BindingSource bindingSource = new();
            bindingSource.DataSource = costumer.accounts;
            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["Balance"].HeaderText = "Bakiye";
            dataGridView.Columns["MusteriID"].HeaderText = "Müşteri No";
            dataGridView.Columns["HesapID"].HeaderText = "Hesap No";
            dataGridView.Columns["costumer"].Visible = false;
            dataGridView.Columns["Islemiter"].Visible = false;
        }

        //datagirdde işlem detaylarını gösterir
        public void Islemdata(DataGridView dataGridView,Islem islem)
        {
            List<Islem> Islems = new();
            Islems.Add(islem);
           
            dataGridView.DataSource = Islems;

            dataGridView.Columns[0].HeaderText = "İşlem ID";
            dataGridView.Columns[1].HeaderText = "İşlem Tarihi";
            dataGridView.Columns[2].HeaderText = "İşlem Tutarı";
            dataGridView.Columns[3].HeaderText = "Bakiye";
            dataGridView.Columns[4].HeaderText = "İşlem Tipi";
            dataGridView.Columns[5].HeaderText = "Açıklama";

            dataGridView.Columns[5].Width = 500;
            dataGridView.Columns[0].Width = 250;
            dataGridView.Columns["bank"].Visible = false;
            dataGridView.Columns["Message"].Visible = false;
        }

        public void ShowCostumerdata(DataGridView dataGridView, Costumer costumer)
        {
            List<Costumer> Scostumer = new();
            Scostumer.Add(costumer);
            dataGridView.DataSource = Scostumer;

            dataGridView.Columns["MusteriID"].HeaderText = "Müşteri No";
            dataGridView.Columns["MusteriTipi"].HeaderText = "Müşteri Tipi";
            dataGridView.Columns["TCKimlikNo"].HeaderText = "TC Kimlik No";
            dataGridView.Columns["MailAdresi"].HeaderText = "Mail Adresi";
            dataGridView.Columns["bank"].Visible = false;
            dataGridView.Columns["accID"].Visible = false;
        }
        public Bank(string name)
        {
            this.Name = name;
            this.BankaGelir = 0;
        }
    }
}
