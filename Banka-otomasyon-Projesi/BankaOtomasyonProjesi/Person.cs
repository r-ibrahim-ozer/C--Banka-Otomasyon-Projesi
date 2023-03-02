using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonProjesi
{
    public abstract class Person
    {
        public long TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string MailAdresi { get; set; }
        public Bank bank { get; set; }

    }
}
