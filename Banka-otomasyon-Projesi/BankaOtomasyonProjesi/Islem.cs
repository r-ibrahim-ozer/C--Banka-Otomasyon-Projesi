using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static BankaOtomasyonProjesi.Islem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BankaOtomasyonProjesi
{
    public abstract class Islem
    {


        public string IslemID { get; set; }
        public DateTime IslemTarih { get; set; }
        public decimal IslemTutarı { get; set; }
        public decimal Balance { get; set; }
        public EIslemTipi IslemTipi { get; set; }
        public string Aciklama { get;  set; }
        public Bank bank { get; set; }
        public string Message { get; set; }

        public enum EIslemTipi
        {
            ParaCekme,
            ParaYatirma,
            HavaleGonder,
            HavaleAl,
            HesapAcma,
            HavaleUcreti
        }

        public bool BakiyeKontrol(decimal miktar, decimal bakiye)
        {
            if ((bakiye - miktar) >= 0) return true;
            else return false;
        }

    }
}
