using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatematikselIslemler
{
    public class GenelIslemler 
    {
        public int UsAl(int sayi,int kuvvet)
        {
            int carpim = 1;
            for (int i = 0; i <kuvvet; i++)
            {
                carpim *= sayi;
            }
            return carpim;

        } 
        public static double Pi = 3.14;

        public int Faktorıyel(int sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {

                sonuc *= i;

            }
            return sonuc;

        }
       
     }
    public class Diferansiyel : GenelIslemler
    {
        public string DifansiyelAl()
        {
            return "Diferansiyel Alındı";
        }

    }
    public class İntegral : GenelIslemler
    {
        public string İntegralAl()
        {
            return " İntegral Alındı";
        }

    }
    public class Geometri : GenelIslemler
    {
        public int BirinciKenar;
        public int İkinciKenar;
        public int Yükseklik;
        public int Taban;
       
    }
    public class Ucgen : Geometri
    {
        public int AlanBul()
        {
            return (Taban * Yükseklik) / 2;
        }
        //İKİNCİ METOT
        public int AlanBul(int taban, int yukseklik)
        {
            return (taban * yukseklik) / 2;
        }

    }
    public class Dikdörtgen : Geometri
    {
        public int AlanBul()
        {
            return BirinciKenar * İkinciKenar;
        }
        //İKİNCİ METOT
        public int AlanBul(int Kenar1, int Kenar2)
        {
            return Kenar1 * Kenar2;
        }

    }
    public class FonksiyonelIslemler : GenelIslemler
    {
        public string FonksiyonAl()
        {
            return " Fonksiyon  Alındı";
        }

    }
}
