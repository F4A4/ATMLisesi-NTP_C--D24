﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KurucuSiniflar
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

        //BU SINIFIN KAPSAM DIŞINDA TANIMLANMIŞ OLMASI
        //MESAJ DEĞİŞKENİNE ATANAN DEĞERİN SİLİNMESİNİ SAĞLAR
        //YANİ YENİ BİR KS NESNESİ TANIMLAMAYA GEREK KALMAZ.
        KuruculuSiniflar2 ks = new KuruculuSiniflar2();
        private void button1_Click(object sender, EventArgs e)
        {
           
            label1.Text = ks.MesajVer();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ks.MesajYaz(textBox1.Text);
            label1.Text = ks.MesajVer();
        }
    }
}
