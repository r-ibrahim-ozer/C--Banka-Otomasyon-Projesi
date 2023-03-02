using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonProjesi
{
    public class Account
    {
        public long MusteriID { get; set; }
        public long HesapID { get; private set; }
        public decimal Balance { get; set; }
        public Costumer costumer { get; set; }
        public List<Islem> Islemler { get; set; } = new();
        // islemiter hesabın yaptığı işlemlerini sayar
        public int Islemiter { get; private set; }

        
        public void IslemEkle(Islem _islem)
        {
            Islemler.Add(_islem);
            Islemiter++;
        }

        // günlük 750TL olan limiti kontrol eder.
        public bool IsPermitedToParaCekme(decimal tutar)
        {
            DateTime datetime = DateTime.Now;
            string time = datetime.ToString("yyyyMMdd");
            decimal total = 0;
            foreach(Islem islem in Islemler)
            {
                if (islem.IslemTarih.ToString("yyyyMMdd") == time && islem.IslemTipi == Islem.EIslemTipi.ParaCekme) total += islem.IslemTutarı;
            }

            if (-tutar + total < -750) return false;
            else return true;
        }


        public Account(Bank _bank,Costumer costumer,decimal balance)
        {
            this.MusteriID = costumer.MusteriID;
            this.Balance = balance;
            this.costumer = costumer;
            this.HesapID = long.Parse(costumer.MusteriID.ToString("00000") + costumer.accID.ToString("000"));
            costumer.AccountEkle(this);
            _bank.AllAccounts.Add(this);
            Islemiter = 100;

        }
    }


}
