using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOPARK_OTOMASYONUU
{
    class Otopark
    {
        //sınıf içerisine sabit bazı değerler tanımlanabilir.
        public const int kücükarac = 5;
        public const int buyukarac = 10;
        //Pi,Memur Maaş Katsayısı belirli katsayılar..

        public string OtoparkAdı { get; set; }
        public int Kapasite { get; set; }
        public int Cüzdan { get; set; }
        public int bulunanaracsayisi { get; set; }
        public Otopark(string _OtoparkAdı,int _Kapasite)
        {
            OtoparkAdı = _OtoparkAdı;
            Kapasite = _Kapasite;
            bulunanaracsayisi = 0;
        }
        public void AracGiris(bool indirimliMi)
        {
            Kapasite--;
            bulunanaracsayisi++;

            if (indirimliMi)
            {
                Cüzdan += kücükarac;
            }
            else
            {
                Cüzdan += buyukarac;
            }
        }
        public void AracCikis()
        {
            Kapasite++;
            bulunanaracsayisi--;
        }
        public int KazançSorgula()
        {
            return Cüzdan;
        }
        public int KapasiteSorgula()
        {
            return Kapasite;
        }
        public int BulunanAraçSayısıSorgula()
        {
            return bulunanaracsayisi;
        }
    }
}
