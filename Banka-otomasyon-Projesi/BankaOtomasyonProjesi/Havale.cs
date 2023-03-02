using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaOtomasyonProjesi
{
    public class Havale : Islem
    {
        // İşlem açıklamanın belirlenmesi
        public void GetAciklama(Account _accoungonderen, Account _accountalici)
        {
            this.Aciklama = _accoungonderen.HesapID + "TARAFINDAN AKTARILAN *" +
                _accoungonderen.costumer.Ad + " " + _accoungonderen.costumer.Soyad +
                "*" + _accountalici.HesapID.ToString() + "NUMARALI HESABA";
        }

        // Havale gönderme işlemi
        public void HavaleGonder(Account gonderen, decimal toplamtutar)
        {
            gonderen.Balance -= toplamtutar;
            this.Message = "İşlem Başarılı";
        }

        // Havale alma işlemi
        public void HavaleAl(Account alici, decimal miktar)
        {
            alici.Balance += miktar;
        }

        // Class constructor
        public Havale(Bank _bank, decimal islemTutarı, decimal miktar, Account _accoungonderen, Account _accountalici, EIslemTipi eIslem)
        {
            
            if (eIslem == EIslemTipi.HavaleAl && BakiyeKontrol(islemTutarı, _accoungonderen.Balance))
            {
                string _islemID = _accountalici.HesapID.ToString("00000000") +
                IslemTarih.ToString("yyyyMMddHHmms") + _accountalici.Islemiter.ToString("000");
                this.IslemID = _islemID;
                HavaleAl(_accountalici, miktar);
                this.IslemTutarı = islemTutarı;
                this.Balance = _accountalici.Balance;
                _accountalici.IslemEkle(this);
            }
            else if(eIslem == EIslemTipi.HavaleGonder && BakiyeKontrol(islemTutarı, _accoungonderen.Balance))
            {
                string _islemID = _accoungonderen.HesapID.ToString("00000000") +
                IslemTarih.ToString("yyyyMMddHHmms") + _accoungonderen.Islemiter.ToString("000");
                this.IslemID = _islemID;
                HavaleGonder(_accoungonderen, islemTutarı);
                this.Balance = _accoungonderen.Balance;
                this.IslemTutarı = (-1.0M) * islemTutarı;
                _accoungonderen.IslemEkle(this);
             }
            else
            {
                this.Message = "Yeterli Bakiye Bulunmamakta";
                this.Aciklama = "BAŞARISIZ İŞLEM";
                this.IslemTutarı = 0;
            }
 
            this.IslemTipi = eIslem;
            this.IslemTarih = DateTime.Now;

            _bank.AllIslems.Add(this);
            GetAciklama(_accoungonderen, _accountalici);

        }
         
            
            
        }
}
