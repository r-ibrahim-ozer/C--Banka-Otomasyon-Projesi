using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static BankaOtomasyonProjesi.Islem;

namespace BankaOtomasyonProjesi
{
    public class ParaYatirma : Islem
    {
        public ParaYatirma(Bank _bank, decimal islemTutarı, Account account)
        {
            this.IslemTarih = DateTime.Now;
            this.IslemID = account.HesapID.ToString("00000000") +
                 IslemTarih.ToString("yyyyMMddHHmmss") + account.Islemiter.ToString("000");
            this.IslemTipi = EIslemTipi.ParaYatirma;
            this.IslemTutarı = islemTutarı;

            Aciklama = account.HesapID.ToString() + "NUMARALI HESABA PARA YATIRMA";
            this.IslemTutarı = islemTutarı;
            account.Balance += this.IslemTutarı;
            this.Message = "İşlem Başarılı";

            this.Balance = account.Balance;

            _bank.AllIslems.Add(this);
            account.IslemEkle(this);
        }


    }
}
