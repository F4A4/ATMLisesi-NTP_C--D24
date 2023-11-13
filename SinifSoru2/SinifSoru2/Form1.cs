using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatematikselIslemler;

namespace SinifSoru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Class türeterek açtığımız diferansiyel class'ı 
            //aşağıdaki gibi çağrılır.
            Diferansiyel dfr = new Diferansiyel();
            MessageBox.Show(dfr.DifansiyelAl());//dfr. dedik . dan sonra içindeki metotun içine yazıyoruz.

            //Ancak Pi alanı(Değişkeni) static olduğu için 
            //miras alan classtan (türetilmeden) çağırılabilir.
            MessageBox.Show(Diferansiyel.Pi.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Class türeterek açtığımız diferansiyel class'ı 
            //aşağıdaki gibi çağrılır.
            İntegral ınt = new İntegral();
            MessageBox.Show(ınt.İntegralAl());//ınt. dedik . dan sonra içindeki metotun içine yazıyoruz.

            //Ancak Pi alanı(Değişkeni) static olduğu için 
            //miras alan classtan (türetilmeden) çağırılabilir.
            MessageBox.Show(İntegral.Pi.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Class türeterek açtığımız diferansiyel class'ı 
            //aşağıdaki gibi çağrılır.
            FonksiyonelIslemler fks = new FonksiyonelIslemler();
            MessageBox.Show(fks.FonksiyonAl());//fks. dedik . dan sonra içindeki metotun içine yazıyoruz.

            //Ancak Pi alanı(Değişkeni) static olduğu için 
            //miras alan classtan (türetilmeden) çağırılabilir.
            MessageBox.Show(FonksiyonelIslemler.Pi.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CLASSLARIN SAHİP OLDUĞU ALANLAR
            //AŞAĞIDAKİ GİBİ KULLANILABİLİR.
            Ucgen ucg = new Ucgen();
            ucg.Taban = Int32.Parse(textBox1.Text);
            ucg.Yükseklik = Int32.Parse(textBox2.Text);
            int sonuc = ucg.AlanBul();

            label6.Text = sonuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CLASSLARIN SAHİP OLDUĞU ALANLAR
            //AŞAĞIDAKİ GİBİ KULLANILABİLİR.
            Dikdörtgen dik = new Dikdörtgen();
            dik.BirinciKenar = Int32.Parse(textBox3.Text);
            dik.İkinciKenar = Int32.Parse(textBox4.Text);
            int sonuc = dik.AlanBul();

            label8.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //İKİNCİ BİR YOL BU YOL İLE İKİNCİ METOTU ÇAĞIRIYORUZ.
            //AŞAĞIDAKİ KULLANILAN ALANBUL METODU CLASSIN
            //SAHİP OLDUĞU HERHANGİ BİR ALANI KULLANMAZ.
            //KENDİ PARAMETRELERİ KULLANIR.
            Ucgen ucg = new Ucgen();
            int Tb = Int32.Parse(textBox1.Text);
            int Yk = Int32.Parse(textBox2.Text);
            int sonuc = ucg.AlanBul(Tb,Yk);

            label6.Text = sonuc.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //İKİNCİ BİR YOL BU YOL İLE İKİNCİ METOTU ÇAĞIRIYORUZ.
            //AŞAĞIDAKİ KULLANILAN ALANBUL METODU CLASSIN
            //SAHİP OLDUĞU HERHANGİ BİR ALANI KULLANMAZ.
            //KENDİ PARAMETRELERİ KULLANIR.
            Dikdörtgen dik = new Dikdörtgen();
            int BK = Int32.Parse(textBox3.Text);
            int İK = Int32.Parse(textBox4.Text);
            int sonuc = dik.AlanBul(BK,İK);

            label8.Text = sonuc.ToString();

        }
    }
   
}
