﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220812Win_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //aynı tipte biden fazla değişken tanımlanacaksa aralarına virgül konularak tanımlanabilir
        int saat = 0, dakika = 0, saniye = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye > 59)
            {
                dakika++;
                if (dakika > 59)
                {
                    saat++;
                    lblSaat.Text = dakika < 10 ? string.Format("0{0}", dakika) : dakika.ToString(); 
                    dakika = 0;
                }
                lblDakika.Text = dakika < 10 ? string.Format("0{0}", dakika) : dakika.ToString();
                saniye = 0;
            }
            lblSaniye.Text=saniye<10? string.Format("0{0}", saniye): saniye.ToString();
            //TURNERY IF TEK SATIRDA IF YAZMA İŞLEMİ
            


        }
    }
}
