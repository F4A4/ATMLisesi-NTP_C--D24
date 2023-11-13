using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MatematikselIslemler;

namespace KodKutuphanem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //class türeterek açtığımız diferansiyel class'ı
            //aşağıdaki gibi kullanılabilir.
            Diferansiyel df = new Diferansiyel();
            MessageBox.Show(df.DiferansiyelAl());

            //ancak pi alanı(değişkeni) static olduğu için
            //miras alan her classtan (türetilmeden) çağırılabilir.
            MessageBox.Show(Diferansiyel.pi.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //class türeterek açtığımız diferansiyel class'ı
            //aşağıdaki gibi kullanılabilir.
            Integral itg = new Integral();
            MessageBox.Show(itg.IntegralAl());

            //ancak pi alanı(değişkeni) static olduğu için
            //miras alan her classtan (türetilmeden) çağırılabilir.
            MessageBox.Show(Integral.pi.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //class türeterek açtığımız diferansiyel class'ı
            //aşağıdaki gibi kullanılabilir.
            FonksiyonelIslemler fnk = new FonksiyonelIslemler();
            MessageBox.Show(fnk.FonksiyonAl());

            //ancak pi alanı(değişkeni) static olduğu için
            //miras alan her classtan (türetilmeden) çağırılabilir.
            MessageBox.Show(FonksiyonelIslemler.pi.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //classların sahip olduğu alanlar
            //aşağıdaki gibi kullanılabilir;
            Ucgen ucg = new Ucgen();
            ucg.birinciKenar = Int32.Parse(textBox1.Text);
            ucg.yukseklik = Int32.Parse(textBox2.Text);
            //AlanBul() metodu bu alanların değerlerini kullanır.
            int sonuc = ucg.AlanBul();
            label6.Text = sonuc.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //aşağıda kullanılan AlanBul metodu
            //classın sahip olduğu herhangi bir alanı kullanmaz.
            //kendi parametrelerini kullanır.
            Ucgen ucg = new Ucgen();
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int sonuc = ucg.AlanBul(a, b);
            label6.Text = sonuc.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //classların sahip olduğu alanlar
            //aşağıdaki gibi kullanılabilir;
            Dikdortgen dkt = new Dikdortgen();
            dkt.birinciKenar = Convert.ToInt32(textBox3.Text);
            dkt.ikinciKenar = Convert.ToInt32(textBox4.Text);
            //AlanBul() metodu bu alanların değerlerini kullanır.
            int sonuc = dkt.AlanBul();
            label6.Text = sonuc.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //aşağıda kullanılan AlanBul metodu
            //classın sahip olduğu herhangi bir alanı kullanmaz.
            //kendi parametrelerini kullanır.
            Dikdortgen dkg = new Dikdortgen();
            int c = Int32.Parse(textBox3.Text);
            int d = Int32.Parse(textBox4.Text);
            int sonuc2 = dkg.AlanBul(c, d);
            label6.Text = sonuc2.ToString();
        }
    }
}
