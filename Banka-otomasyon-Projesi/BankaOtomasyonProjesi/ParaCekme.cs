using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static BankaOtomasyonProjesi.Islem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaOtomasyonProjesi
{
    public class ParaCekme:Islem
    {
        

        public ParaCekme(Bank _bank, decimal islemTutarı, Account account)
        {
            this.IslemTarih = DateTime.Now;
            this.IslemID = account.HesapID.ToString("00000000") +
                 IslemTarih.ToString("yyyyMMddHHmmss") + account.Islemiter.ToString("000");
            this.IslemTipi = EIslemTipi.ParaCekme;
            this.IslemTutarı = (-1) * islemTutarı;

            Aciklama = account.HesapID.ToString() + "NUMARALI HESAPTAN PARA ÇEKME";


            if (BakiyeKontrol(islemTutarı,account.Balance))
            {
                account.Balance += this.IslemTutarı;
                this.Message = "İşlem Başarılı";

            }
            else
            {
                this.Message = "Yeterli Bakiye Bulunmamakta";
                this.IslemTutarı = 0;
                this.Aciklama = "BAŞARISIZ İŞLEM";
            }
            this.Balance = account.Balance;
            _bank.AllIslems.Add(this);
            account.IslemEkle(this);
        }
    }
    
}
