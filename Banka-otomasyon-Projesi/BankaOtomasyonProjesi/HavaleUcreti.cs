using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonProjesi
{
    public class HavaleUcreti : Islem
    {

        // Havale tutarının hesaplanması
        public decimal HavaleTutarHesapla(Account account, decimal miktar)
        {
            decimal havaleTutar = 0;
            if (account.costumer.MusteriTipi == Costumer.EMusteriTipi.Bireysel)
            {
                havaleTutar = miktar * (0.02M);
                return havaleTutar;
            }
            else return havaleTutar;
        }

        public HavaleUcreti(Bank _bank, Account gonderenaccount,Account aliciaccount, decimal miktar)
        {
            this.IslemTarih = DateTime.Now;
            this.IslemID = gonderenaccount.HesapID.ToString("00000") + aliciaccount.HesapID.ToString("00000")+
                IslemTarih.ToString("yyMMddHHmm");
            this.IslemTutarı = HavaleTutarHesapla(gonderenaccount, miktar);
            _bank.BankaGelir+=IslemTutarı;
            this.Balance = _bank.BankaGelir;
            this.IslemTipi = EIslemTipi.HavaleUcreti;
            this.Aciklama = gonderenaccount.HesapID.ToString("00000000") + aliciaccount.HesapID.ToString("00000000")
                + " HESAPTAN HAVALE ÜCRETİ";

            _bank.AllIslems.Add(this);
            
        }
    }
}
