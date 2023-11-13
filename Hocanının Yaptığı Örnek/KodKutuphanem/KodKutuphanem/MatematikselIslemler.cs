using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatematikselIslemler
{
    public class GenelIslemler
    {
        public int UsAl(int sayi, int kuvvet)
        {
            int carpim = 1;

            for (int i = 0; i < kuvvet; i++)
            {
                carpim *= sayi;
            }

            return carpim;
        }

        public int FaktoriyelBul(int sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            return sonuc;
        }

        public static double pi = 3.14;
    }

    public class Diferansiyel:GenelIslemler
    {
        /// <summary>
        /// Bu metot pek işe yaramaz
        /// Sadece denemek için yazdık
        /// </summary>
        /// <returns></returns>
        public string DiferansiyelAl()
        {
            return "diferansiyeli bulundu";
        }
    }

    public class Integral:GenelIslemler
    {
        public string IntegralAl()
        {
            return "integrali bulundu";
        }
    }

    public class Geometri:GenelIslemler
    {
        public int birinciKenar;
        public int ikinciKenar;
        public int yukseklik;
    }

    public class FonksiyonelIslemler:GenelIslemler
    {
        public string FonksiyonAl()
        {
            return "fonksiyonu bulundu";
        }
    }

    public class Ucgen:Geometri
    {
        public int AlanBul()
        {
            return (birinciKenar * yukseklik) / 2;
        }
        public int AlanBul(int taban, int yuksek)
        {
            return (taban * yuksek) / 2;
        }
    }

    public class Dikdortgen:Geometri
    {
        public int AlanBul()
        {
            return birinciKenar * ikinciKenar;
        }
        public int AlanBul(int kisaKenar, int uzunKenar)
        {
            return kisaKenar * uzunKenar;
        }
    }
}
