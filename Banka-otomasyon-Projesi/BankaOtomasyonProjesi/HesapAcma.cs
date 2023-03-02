using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BankaOtomasyonProjesi
{
    public class HesapAcma : Islem
    {

        public HesapAcma(Bank _bank, Account account)
        {
            this.IslemTarih = DateTime.Now;
            this.IslemTutarı = 0;
            this.Balance = account.Balance = 0;
            this.IslemID = "00000" + account.HesapID.ToString("00000") +
                IslemTarih.ToString("yyyyMMddHHmmss");
            this.Aciklama = account.HesapID.ToString() + "NUMARALI HESAP AÇMA";
            this.IslemTipi = EIslemTipi.HesapAcma;

            account.IslemEkle(this);
            _bank.AllIslems.Add(this);

        }

    }
}
