using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinifÖdev
{
    public class TopluMetotlar
    {
        public string metinselKullanım;
        public int matemetiselKullanım;
       
    }
    public class MatematikselMetotlar : TopluMetotlar
    {
        public int DenemeMetot2(int sayi)
        {
            return sayi * sayi;
        }

        /////////////////////////////////////////////////////////

        public int Alan(int kısakenar, int uzunkenar)
        {
            return kısakenar * uzunkenar;
        }


        /////////////////////////////////////////////////////////

        public int UcgenAlan(int taban, int yukseklık)
        {
            return taban * yukseklık / 2;

        }

        /////////////////////////////////////////////////////////

        public int BuyukSayı(int sayi1, int sayi2)
        {
            int sonuc = 0;
            if (sayi1 > sayi2)
            {
                sonuc = sayi1;

            }
            else if (sayi1 < sayi2)
            {
                sonuc = sayi2;
            }

            return sonuc;

        }

        /////////////////////////////////////////////////////////

        public int Faktorıyel(int sayılar)
        {
            int sonuc5 = 1;
            //i 1den başlamalı
            //sayi dahil olmalı
            //carpim 0 olursa sonuc 0 çıkar yani 1 olmalı
            for (int i = 1; i <= sayılar; i++)
            {

                sonuc5 = sonuc5 * i;

            }
            return sonuc5;

        }

        /////////////////////////////////////////////////////////

        public int UsAlma(int sayi)
        {

            return sayi * sayi;

        }

        /////////////////////////////////////////////////////////

        public int UsAlma(int sayi1, int usal)
        {
            int sonuc = 1;
            for (int i = 0; i < usal; i++)
            {
                sonuc = sonuc * sayi1;
            }
            return sonuc;
        }

        /////////////////////////////////////////////////////////

        public void Deneme(int sayi)
        {
            MessageBox.Show(sayi.ToString());
        }
        /////////////////////////////////////////////////////////

        public void Metot3(int s1, int s2)
        {
            MessageBox.Show((s1 * s2).ToString());

        }

        /////////////////////////////////////////////////////////

        public int Metot4(int s3, int s4)
        {
            return s3 * s4;

        }
        
        //--------------------------------------------------------------

     }
    public class MetinselMetotlar : TopluMetotlar
    {
        public void DenemeMetot(string mesaj)
        {
            MessageBox.Show(mesaj);
        }

        /////////////////////////////////////////////////////////

        public string metot2(string metin, string metin1, string metin2)
        {
            string bilestir = metin + metin1 + metin2;
            string Bbilestir = bilestir.ToUpper();

            return Bbilestir;

        }

        /////////////////////////////////////////////////////////

        public void Metot()
        {
            MessageBox.Show("Hoşgeldin FATMA");

        }

        /////////////////////////////////////////////////////////

        public string Metot2()
        {
            return "Hoşgeldin Gönlümün Sultanı";

        }


        /////////////////////////////////////////////////////////

        public void Metot3(string mesaj)
        {
            MessageBox.Show(mesaj);

        }

        /////////////////////////////////////////////////////////

        public void sorubir(string metin)
        {
            MessageBox.Show(metin);

        }

        /////////////////////////////////////////////////////////

        public string soruıkı(string metin, string deger)
        {
            string sonuc;
            if (deger == "Büyük Yaz")
            {
                sonuc = metin.ToUpper();
            }
            else if (deger == "Küçük Yaz")
            {
                sonuc = metin.ToLower();
            }
            else
            {
                return metin;
            }
            return sonuc;
        }

        /////////////////////////////////////////////////////////

        public void Deneme(string metin)
        {
            MessageBox.Show(metin);

        }

        /////////////////////////////////////////////////////////

        public string MesajVer(string metin)
        {
            if (radioButton1.Checked)
            {
                return metin.ToUpper();
            }
            else
            {
                return metin.ToLower();
            }


        }

        /////////////////////////////////////////////////////////

        public string Soru3(string metin1, string metin2)
        {

            return metin1 + metin2;
        }

        //-------------------------------------------------------
 
    }
    public class KarısıkMetotlar : TopluMetotlar
    {
        public int YilGoster()
        {
            return DateTime.Now.Year;
        }

        /////////////////////////////////////////////////////////

        public bool DogruYanlıs(int sy1, int sy2)
        {
            bool sonuc3;
            if (sy1 > sy2)
            {
                sonuc3 = true;

            }
            else if (sy1 < sy2)
            {
                sonuc3 = false;
            }
            else
            {
                sonuc3 = true;
            }

            return sonuc3;
        }

        /////////////////////////////////////////////////////////

        public void sorubir(string deger, bool metin)
        {
            if (metin == true)
            {
                MessageBox.Show(deger.ToUpper());

            }
            else if (metin == false)
            {
                MessageBox.Show(deger.ToLower());
            }
            else
            {
                MessageBox.Show(deger.ToString());
            }

        }

        /////////////////////////////////////////////////////////

        public void Deneme(string metin, int sayi)
        {
            MessageBox.Show(metin + " " + sayi.ToString());
        }

        /////////////////////////////////////////////////////////

        public void tıklama(TextBox t1)
        {

            sayi = sayi + 1;
            t1.Text = sayi.ToString();

        }

        /////////////////////////////////////////////////////////

        public int OrtalamaBul(TextBox sinav1, TextBox sinav2, TextBox sinav3, TextBox sozlu1, TextBox sozlu2)
        {
            int ortMat = 0;

            try
            {
                int snv1 = int.Parse(sinav1.Text);
                int snv2 = int.Parse(sinav2.Text);
                int snv3 = int.Parse(sinav3.Text);
                int soz1 = int.Parse(sozlu1.Text);
                int soz2 = int.Parse(sozlu2.Text);

                if ((snv1 <= 100 && snv1 >= 0) && (snv2 <= 100 && snv2 >= 0) && (snv3 <= 100 && snv3 >= 0) && (soz1 <= 100 && soz1 >= 0) && (soz2 <= 100 && soz2 >= 0))
                {
                    ortMat = (snv1 + snv2 + snv3 + soz1 + soz2) / 5;
                }
                else
                {
                    MessageBox.Show("notları 0-100 aralığında giriniz..");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş");

            }

            return ortMat;
        }

        /////////////////////////////////////////////////////////

        public double Soru1(double sayi1)
        {
            double sonuc = (sayi1 * sayi1) / (2 * sayi1);
            return sonuc;
        }

        /////////////////////////////////////////////////////////

        public bool Soru2(int sayi1)
        {
            bool sonuc1;
            if (sayi1 % 2 == 0)
            {
                sonuc1 = true;
            }
            else
            {
                sonuc1 = false;
            }

            return sonuc1;
        }

        /////////////////////////////////////////////////////////

        public double Soru4(int sayi5, int sayi6)
        {

            return (2 * 22 / 7 * sayi5 * sayi6) + (2 * 22 / 7 * sayi5 * sayi5);

        }

        /////////////////////////////////////////////////////////

        public string FibonacciBul(TextBox t1)
        {
            int deger = Int32.Parse(t1.Text);
            int sayi = 1, sayi2 = 1;
            int tpl = 0;
            string sonuc = "1-1";


            for (; ; )
            {
                tpl = sayi + sayi2;

                if (tpl > deger)
                {
                    break;
                }

                sonuc += "-" + tpl.ToString();
                sayi = sayi2;
                sayi2 = tpl;

            }
            return sonuc;

        }

        /////////////////////////////////////////////////////////

        public bool NoktaVarmi(string metin)
        {
            if (metin.EndsWith("."))
                return true;
            else
                return false;
        }


        /////////////////////////////////////////////////////////

        public float VKIBul(byte kilo, float boy)
        {
            float vki = kilo / (boy * boy);
            return vki;
        }


        /////////////////////////////////////////////////////////

        public bool SifreKontrol(string sifre)
        {
            bool durum = true;

            if (sifre.Length < 10)
            {
                durum = false;
            }

            if (char.IsDigit(sifre, 0))
            {
                durum = false;
            }

            return durum;
        }

        /////////////////////////////////////////////////////////

        public byte KacTaneBildi(byte t1, byte t2, byte t3, byte[] makine)
        {


            byte bilinen = 0;
            for (int i = 0; i < makine.Length; i++)
            {
                if (makine[i] == t1)
                    bilinen += 1;

                if (makine[i] == t2)
                    bilinen += 1;

                if (makine[i] == t3)
                    bilinen += 1;
            }
            return bilinen;
        }

        //----------------------------------------------------------
 
    }
}
