using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BankaOtomasyonProjesi.Costumer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BankaOtomasyonProjesi
{
    public class Costumer : Person
    {
        // müşteri no thisID değerine göre atanır.
        public static int thisID = 10001;

        public long MusteriID { get; set; }
        public int accID { get; private set; }
        public EMusteriTipi MusteriTipi { get; set; }


        public List<Account> accounts = new List<Account>();  // Müşterinin sahip olduğu hesap listesi 
        
        public void AccountEkle(Account _account)  // Müşteri hesap listesine hesap eklenmesi
        {
            accounts.Add(_account);
            accID++;
        }

        public enum EMusteriTipi  
        {
            Bireysel,
            Ticari
        }

        //Costumer listesinde MüşretiId'ye göre arama
        public Costumer FindWithMusteriID(long _MusteriID)
        {
            bool found = false;
            Costumer selectedCostumer = bank.Costumers[0];
            foreach (Costumer costumer in bank.Costumers)
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

        // Class constructor
        public Costumer()
        {
            this.MusteriID = thisID;
            // thisId statik değerinin arttırımı
            thisID++;
            accID = 1; 

        }

        public Costumer(long tckimlikNo, string ad,
            string soyad, string adres, string telefonNo,
            string mailAdresi,string musteriTipi,Bank _bank)
        {
            this.MusteriID = thisID;
            // thisId statik değerinin arttırımı
            thisID++;
            // Müşteri oluşumuyla ile hesapID değeri 1 olur
            accID = 1;
            TCKimlikNo = tckimlikNo;
            Ad = ad;
            Soyad = soyad;
            Adres = adres;
            Telefon = telefonNo;
            MailAdresi = mailAdresi;

            // Müşteri tipi belirlenir
            this.MusteriTipi = EMusteriTipi.Bireysel;
            if (musteriTipi == "Ticari") this.MusteriTipi = EMusteriTipi.Ticari;

            //Müşteri banka müşteri listesine eklenir
            _bank.Costumers.Add(this);
        }

    }
}
