using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonProjesi
{
    public class User : Person
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public User(long kimlikNo,string ad,string soyad,string adres,string telefon,string mail, Bank bank)
        {
            TCKimlikNo = kimlikNo;
            Ad = ad;
            Soyad = soyad;
            Adres = adres;
            Telefon = telefon;
            MailAdresi = mail;
            this.bank = bank;
            bank.Users.Add(this);
        }

        public User(Bank bank)
        {
            this.bank = bank;
            bank.Users.Add(this);
        }
    }
}
