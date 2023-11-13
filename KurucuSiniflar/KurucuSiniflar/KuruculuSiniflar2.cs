using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KurucuSiniflar
{
    //private olan mesaj değişkenine 3 yolla değer atayabiliriz:
    //1.yol: bu değişkene değer atamakta veya değerini almakta kullanılan
    //metotlar tanımlamak.
    //2.yol: bu değişkene değer ataması yapan constructor veya
    //aşırı yüklenmiş kurucu(overloaded constructor) kullanmak.
    //3.yol: property kullanmaktır, bunu sonra anlatacağız.
    class KuruculuSiniflar2
    {
        //CONSTRUCTOR:
        public KuruculuSiniflar2()
        {
            mesaj = "BU MESAJ CONSTRUCTOR İÇİNDE ATANDI";
 
        }
        //OVERLOADED CONSTRUCTOR:
        public KuruculuSiniflar2(string ms)
        {
            mesaj = ms;
        }

        //KURUCU : CONSTRUCTOR
        private string mesaj = "BU CONSTRUCTOR KULLANILAN SINIFIN PRİVATE DEĞERİNİN MESAJIDIR";
        public string MesajVer()
        {
            //MESAJ DEĞİŞKİNİNE ERİŞİMİ KONTROL ALTINA ALDIK..
            return mesaj;
        }
        public void MesajYaz(string ms)
        {
            //HER TÜRLÜ HİLEYİ BU METOT İÇERİSİNDE YAPABİLİRİZ.
            //ANCAK SAÇMA OLUR..
            mesaj = ms;
        }
    }
}
