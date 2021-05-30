/****************************************************************************
**					          SAKARYA ÜNİVERSİTESİ
**			         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				         BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				        NESNEYE DAYALI PROGRAMLAMA DERSİ
**
**				ÖDEV NUMARASI....:2
**				ÖĞRENCİ ADI......:BUSE ŞENÖZ
**				ÖĞRENCİ NUMARASI.:B201210025
**				DERS GRUBU.......:A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B201210025_NDP_ODEV_2_SORU_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniSayfa = new Form2();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();//ilgili formu açar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeniSayfa = new Form3();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 yeniSayfa = new Form4();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 yeniSayfa = new Form5();
            this.Hide();
            yeniSayfa.ShowDialog();
            this.Show();
        }


    }
}
